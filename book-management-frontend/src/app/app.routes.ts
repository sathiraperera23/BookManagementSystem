import { Routes } from '@angular/router';
import { BookList } from './components/book-list/book-list';
import { BookForm } from './components/book-form/book-form';

export const appRoutes: Routes = [
  { path: '', component: BookList },
  { path: 'add', component: BookForm },
  { path: 'edit/:id', component: BookForm },
  { path: '**', redirectTo: '' }
];