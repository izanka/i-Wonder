import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {

  movies = [
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'},
    {title: 'ABC'}
  ]

  details = [
    { name: 'Year' },
    { name: 'Director' },
    { name: 'Plot' },
    { name: 'Rotten Tomatoes Rating' },
    { name: 'Poster' }
  ]

  constructor() { }

  ngOnInit() {
    fetch('https://www.omdbapi.com/?s=batman&apikey=991484d1').then(response => response.json()).then(res => this.movies = res.Search);
  }

}

