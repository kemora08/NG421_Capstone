import { Component, OnInit } from '@angular/core';
import { BillBoardMusicListMember } from '../interfaces/bill-board-music-list-member';
import { BillBoardMusicListService } from '../services/bill-board-music-list.service';

@Component({
  selector: 'app-bill-board-music-list',
  templateUrl: './bill-board-music-list.component.html',
  styleUrls: ['./bill-board-music-list.component.css']
})
export class BillBoardMusicListComponent implements OnInit {
  public bbml: BillBoardMusicList[];
  public newBillBoardMusicList: BillBoardMusicList = {firstName: '', lastName: ''};

  public BillBoardMusicListMembers: BillBoardMusicListMember[];
  newBillBoardMusicList: any;
  http: any;
  baseUrl: string;
  billboardmusiclist: any;
  constructor(private BBLMService: BillBoardMusicListService) { }

  async ngOnInit() {
    this.BillBoardMusicListMembers = await this.BBLMService.getMembers();
  }
  async save() {
    await this.http.post<BillBoardMusicList[]>(this.baseUrl + 'BillBoardMusicList', this.BillBoardMusicList).toPromise();
    this.newBillBoardMusicList = { firstName: '', lastName: ''};
    this.BillBoardMusicList = await this.http.get<this.BillBoardMusicList[] > (this.baseUrl + 'BillBoardMusicList'); toPromise();

  }
}
