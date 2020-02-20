using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace TestSchedule
{
    class ScheduleTwo
    {
        IScheduler scheduler2;
        IJobDetail job = JobBuilder.Create<Job>().Build();
        ITrigger trigger3, trigger4;
        ISchedulerFactory schedFact = new StdSchedulerFactory();


        public bool checkScheduleStarted()
        {
            scheduler2 = StdSchedulerFactory.GetDefaultScheduler();
            return scheduler2.IsStarted;
        }

        public void runSecond(int second, string key)
        {
            scheduler2 = StdSchedulerFactory.GetDefaultScheduler();
            scheduler2.Start();
            trigger3 = TriggerBuilder.Create()
                .WithIdentity(key, "group2")
                .StartAt(DateTime.Now.AddSeconds(second))
                .Build();
            scheduler2.ScheduleJob(job, trigger3);
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

        public void Stop()
        {
            if (scheduler2.IsStarted)
            {
                scheduler2.Shutdown();
            }
        }
    }
}
