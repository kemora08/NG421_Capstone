import { Component, OnInit } from '@angular/core';
import { BillBoardMusicListMember } from '../interfaces/bill-board-music-list-member';
import { BillBoardMusicListService } from '../services/bill-board-music-list.service';

@Component({
  selector: 'app-bill-board-music-list',
  templateUrl: './bill-board-music-list.component.html',
  styleUrls: ['./bill-board-music-list.component.css']
})
export class BillBoardMusicListComponent implements OnInit {
  public bbml: BillBoardMusicListMember[];
  public newBillBoardMusicList: BillBoardMusicListMember = {
    Id: 1,
    Artist: '',
    Song: '',
    Duration: '',
    Genre: '',
    Membersince: null,
    IsActiveMember: true
   };


  public BillBoardMusicListMembers: BillBoardMusicListMember[];
  public newBillBoardMusicListMembers: any;
  http: any;
  baseUrl: string;
  billboardmusiclist: any;
  constructor(private BBLMService: BillBoardMusicListService) { }


  async ngOnInit() {
    this.BillBoardMusicListMembers = await this.BBLMService.getMembers();
  }
  async save() {
    await this.BBLMService.getMembers();
    this.newBillBoardMusicListMembers = {
      Id: '',
      Artist: '',
      Song: '',
      Duration: '',
      Genre: '',
      Membersince: null,
      IsActiveMember: true
     };
    this.billboardmusiclist = await this.http.get.this.billboardmusiclist > (this.baseUrl + 'BillBoardMusicList');

  }

}
