import { Component, OnInit, Input } from '@angular/core';



@Component({
  selector: 'app-home',
  templateUrl: './home-page.html',
  styleUrls: ['./home-page.css']
})
export class HomePageComponent implements OnInit {
  @Input() title: Title;
  constructor() { 


  }

  ngOnInit() {
  }

}