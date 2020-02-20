using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace TestSchedule
{
    class Schedule
    {
        IScheduler scheduler, scheduler2, scheduler3;

        ITrigger trigger1, trigger2, trigger3, trigger4, trigger5;
        ISchedulerFactory schedFact = new StdSchedulerFactory();


        public void Start(int hour, int minute, string key)
        {
            IJobDetail job = JobBuilder.Create<Job>().Build();
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            trigger1 = TriggerBuilder.Create()
                .WithIdentity(key, "group1")
                .WithDailyTimeIntervalSchedule(
                    s =>
                        s.WithIntervalInHours(24)
                        .OnEveryDay()
                        .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(hour, minute))
                ).Build();
            scheduler.ScheduleJob(job, trigger1);
        }

        public void Update(int hour, int minute, string key)
        {
            ITrigger oldTrigger = scheduler.GetTrigger(trigger1.Key);

            trigger2 = TriggerBuilder.Create()
                .WithIdentity(key, "group1")
                .WithDailyTimeIntervalSchedule(
                    s =>
                        s.WithIntervalInHours(24)
                        .OnEveryDay()
                        .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(hour, minute))
                ).Build();

            // tell the scheduler to remove the old trigger with the given key, and put the new one in its place
            scheduler.RescheduleJob(oldTrigger.Key, trigger2);
        }

        public bool checkScheduleStarted()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
            return scheduler.IsStarted;
        }

        public void runSecond(int second, string key)
        {
            IJobDetail job2 = JobBuilder.Create<Job>().Build();
            scheduler2 = StdSchedulerFactory.GetDefaultScheduler();
            scheduler2.Start();
            trigger3 = TriggerBuilder.Create()
                .WithIdentity(key, "group2")
                .StartAt(DateTime.Now.AddSeconds(second))
                .Build();
            scheduler2.ScheduleJob(job2, trigger3);
        }

        public void updateSecond(int second, string key)
        {
            ITrigger oldTriggerSecond = scheduler2.GetTrigger(trigger3.Key);
            trigger4 = TriggerBuilder.Create()
                .WithIdentity(key, "group2")
                .StartAt(DateTime.Now.AddSeconds(second))
                .Build();
            scheduler2.RescheduleJob(oldTriggerSecond.Key, trigger4);
        }

        public void repeatJob(int second, string key)
        {
            IJobDetail job3 = JobBuilder.Create<Job>().Build();
            scheduler3 = StdSchedulerFactory.GetDefaultScheduler();
            scheduler3.Start();
            trigger5 = TriggerBuilder.Create()
                .WithIdentity(key, "group3")
                .StartNow()
                .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(second)
                .RepeatForever())
                .Build();
            scheduler3.ScheduleJob(job3, trigger5);
        }

        public void Stop()
        {
            if (scheduler.IsStarted)
            {
                scheduler.Shutdown();
            }
        }
    }
}
