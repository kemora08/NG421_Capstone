import { Component, OnInit } from '@angular/core';
import { BillBoardMusicListMember } from '../interfaces/bill-board-music-list-member';
import { BillBoardMusicListService } from '../services/bill-board-music-list.service';

@Component({
  selector: 'app-bill-board-music-list',
  templateUrl: './bill-board-music-list.component.html',
  styleUrls: ['./bill-board-music-list.component.css']
})
export class BillBoardMusicListComponent implements OnInit {
  public newBillBoardMusicList: BillBoardMusicListMember = {
    artist: '',
    song: '',
    duration: '',
    genre: '',
   };

  public BillBoardMusicListMembers: BillBoardMusicListMember[];
  constructor(private BBLMService: BillBoardMusicListService) { }

  async ngOnInit() {
    this.BillBoardMusicListMembers = await this.BBLMService.getMembers();
  }

  async save() {
    await this.BBLMService.addMember(this.newBillBoardMusicList);
    this.BillBoardMusicListMembers.push(this.newBillBoardMusicList);
  }

}
