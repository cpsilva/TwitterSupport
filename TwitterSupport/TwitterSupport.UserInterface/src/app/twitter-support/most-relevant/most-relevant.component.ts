import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/shared/services/http.service';
import { TweetMostRelevant } from 'src/app/model/tweetMostRelevant.model';
import { Router } from '@angular/router';

@Component({ selector: 'app-twitter-support-most-relevant', templateUrl: './most-relevant.component.html' })
export class TwitterSupportMostRelevantComponent implements OnInit {
  tweets: TweetMostRelevant[] = new Array<TweetMostRelevant>();

  constructor(private readonly httpService: HttpService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.getTweetsMostRelevant();
  }
  getTweetsMostRelevant(): any {
    this.httpService.get<Array<TweetMostRelevant>>('Tweet/MostRelevant').subscribe(result => {
      this.tweets = result;
    });
  }

  goTo() {
    this.router.navigate(['twitter-support/most-mentions']);
  }
}
