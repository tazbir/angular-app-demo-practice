import { Component, OnInit } from '@angular/core';
import { BookService } from "../../services/book.service";

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  public books: IBook[];

  constructor(private service: BookService) { }

  ngOnInit() {
    this.service.getAllBooks().subscribe(data => {
      this.books = data;
    });
  }

}
