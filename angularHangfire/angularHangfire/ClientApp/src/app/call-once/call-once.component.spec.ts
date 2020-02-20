import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallOnceComponent } from './call-once.component';

describe('CallOnceComponent', () => {
  let component: CallOnceComponent;
  let fixture: ComponentFixture<CallOnceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallOnceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallOnceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
