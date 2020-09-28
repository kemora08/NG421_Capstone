import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { BillBoardMusicListMember } from '../interfaces/bill-board-music-list-member';

@Injectable({
  providedIn: 'root'
})
export class BillBoardMusicListService {

  constructor(private httpClient: HttpClient,
             @Inject('BASE_URL')private baseURL: string) { }

  public async getMembers(): Promise<BillBoardMusicListMember[]> {
    return this.httpClient.get<BillBoardMusicListMember[]>(`${this.baseURL}BBLM`).toPromise();
  }
}
