import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TweetMostMentions } from 'src/app/model/TweetMostMentioned.model';
import { HttpService } from 'src/app/shared/services/http.service';

@Component({ selector: 'app-twitter-support-most-mentions', templateUrl: './most-mentions.component.html' })
export class TwitterSupportMostMentionsComponent implements OnInit {
  tweets: TweetMostMentions[] = new Array<TweetMostMentions>();

  constructor(private readonly router: Router,
    private readonly httpService: HttpService) { }

  ngOnInit(): void {
    this.getTweets();
  }
  getTweets(): any {
    this.httpService.get<Array<TweetMostMentions>>('Tweet/MostMentions').subscribe(result => {
      this.tweets = result;
    });
  }

  goBack() {
    this.router.navigate(['twitter-support/most-relevant']);
  }
}
