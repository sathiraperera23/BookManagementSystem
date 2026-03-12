import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterModule, ActivatedRoute } from '@angular/router';
import { BookService } from '../../services/book.service';
import { Book } from '../../model/book';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-book-form',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './book-form.html',
  styleUrls: ['./book-form.css']
})
export class BookForm implements OnInit {
  book: Book = { id: 0, title: '', author: '', isbn: '', publicationDate: new Date().toISOString() };
  isEdit = false;

  constructor(private bookService: BookService, private router: Router, private route: ActivatedRoute) {}

  ngOnInit(): void {
    const id = this.route.snapshot.params['id'];
    if (id) {
      this.isEdit = true;
      this.bookService.getBook(+id).subscribe(data => this.book = data);
    }
  }

  save(): void {
    if (this.isEdit) {
      this.bookService.updateBook(this.book).subscribe(() => this.router.navigate(['/']));
    } else {
      this.bookService.createBook(this.book).subscribe(() => this.router.navigate(['/']));
    }
  }
}