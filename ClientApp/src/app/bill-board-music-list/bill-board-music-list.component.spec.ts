import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BillBoardMusicListComponent } from './bill-board-music-list.component';

describe('BillBoardMusicListComponent', () => {
  let component: BillBoardMusicListComponent;
  let fixture: ComponentFixture<BillBoardMusicListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BillBoardMusicListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BillBoardMusicListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
