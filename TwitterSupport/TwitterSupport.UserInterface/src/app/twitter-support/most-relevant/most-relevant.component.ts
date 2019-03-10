import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/shared/services/http.service';
import { TweetMostRelevant } from 'src/app/model/tweetMostRelevant.model';

@Component({ selector: 'app-twitter-support-most-relevant', templateUrl: './most-relevant.component.html' })
export class TwitterSupportMostRelevantComponent implements OnInit {

  constructor(private readonly httpService: HttpService) { }
  tweets: TweetMostRelevant[] = new Array<TweetMostRelevant>();
  ngOnInit(): void {
    this.listar();
  }
  listar(): any {
    this.httpService.get<Array<TweetMostRelevant>>('Tweet').subscribe(result => {
      this.tweets = result;
    });
  }
}
