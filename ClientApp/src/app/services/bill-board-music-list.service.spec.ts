import { TestBed } from '@angular/core/testing';

import { BillBoardMusicListService } from './bill-board-music-list.service';

describe('BillBoardMusicListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BillBoardMusicListService = TestBed.get(BillBoardMusicListService);
    expect(service).toBeTruthy();
  });
});
