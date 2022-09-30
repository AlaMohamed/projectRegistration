import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeregistrationComponent } from './timeregistration.component';

describe('TimeregistrationComponent', () => {
  let component: TimeregistrationComponent;
  let fixture: ComponentFixture<TimeregistrationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TimeregistrationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TimeregistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
