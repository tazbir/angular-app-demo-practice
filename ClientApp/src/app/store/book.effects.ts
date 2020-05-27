import { BookService } from '../services/book.service';
import { Actions, Effect, ofType } from '@ngrx/effects';
import { Observable } from 'rxjs';
import { Action } from '@ngrx/store';
import * as types from './action.types';
import * as bookActions from "./book.action";
import { mergeMap,map } from 'rxjs/operators';

export class BookEffects {
  constructor(private service: BookService,
    private actions$: Actions) {
  }

  @Effect() loadBooks$: Observable<Action> = this.actions$.pipe(
    ofType<bookActions.loadBooksAction>(types.LOAD_BOOKS), mergeMap(() =>
      this.service.getAllBooks().pipe(map(books=> new bookActions.loadBooksAction(books)))));
}
