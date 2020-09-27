import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BBLMComponent } from './bblm.component';

describe('BBLMComponent', () => {
  let component: BBLMComponent;
  let fixture: ComponentFixture<BBLMComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BBLMComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BBLMComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
