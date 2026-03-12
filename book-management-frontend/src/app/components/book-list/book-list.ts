import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { BookService } from '../../services/book.service';
import { Book } from '../../model/book';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './book-list.html',
  styleUrls: ['./book-list.css']
})
export class BookList implements OnInit {
  books: Book[] = [];
  loading = true;

  constructor(private bookService: BookService, private router: Router) {}

  ngOnInit(): void {
    this.loadBooks();
  }

  loadBooks(): void {
    this.bookService.getBooks().subscribe({
      next: (data) => {
        this.books = data;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error loading books:', err);
        this.loading = false;
      }
    });
  }

  deleteBook(id: number): void {
    if (confirm('Are you sure?')) {
      this.bookService.deleteBook(id).subscribe(() => this.loadBooks());
    }
  }

  editBook(id: number): void {
    this.router.navigate(['/edit', id]);
  }

  addBook(): void {
    this.router.navigate(['/add']);
  }

  trackById(index: number, book: Book): number {
    return book.id;
  }
}