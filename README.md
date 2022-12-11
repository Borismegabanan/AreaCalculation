# AreaCalculation

Тестовое задание.

Задание 1.  в папке src

комментарии 

_Вычисление площади фигуры без знания типа фигуры в compile-time_ - как будто для этого фигуры должны преподносится в системе координат. 

Задание 2.
Ну, во-первых должна быть ещё промежуточная таблица чтобы разбить связь N:M на N:1 M:1.
Так что добавим промежуточную таблицу CategoriesAndProducts

Тогда запрос будет такой, если я правильно понял задание 

```
select products."Name", categories."Name"  from CategoriesAndProducts c 
right join products on products.id =c.productid
left join categories on categories.id  = c.categoryid 
order by products."Name"
```
