import { Component } from '@angular/core';
import { Recipe } from '../recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent {
recipes: Recipe[] = [
  new Recipe('Cake','delicious chocolate cake','https://assets.winni.in/product/primary/2014/6/31438.jpeg?dpr=1&w=1000'),
  new Recipe('Strawberry','fresh stawberry','https://themes.getmotopress.com/frutta-verde/wp-content/uploads/sites/35/2020/05/strawberries.jpg'),
  new Recipe('Chicken','delicious dum biryani','https://glebekitchen.com/wp-content/uploads/2019/12/chickenbiryanibowltop.jpg')
];
}
