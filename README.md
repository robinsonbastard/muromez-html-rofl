# Тестовое задание: 
Web-Сервис сотрудников, сделанный на платформе .Net Core.
**Сервис должен уметь:**
1. Добавлять сотрудников, в ответ должен приходить Id добавленного сотрудника.
2. Удалять сотрудников по Id.
3. Выводить список сотрудников для указанной компании. Все доступные поля.
4. Выводить список сотрудников для указанного отдела компании. Все доступные поля.
5. Изменять сотрудника по его Id. Изменения должно быть только тех полей, которые указаны в запросе.
**Модель сотрудника:**
```
{
  Id int
  Name string
  Surname string
  Phone string
  CompanyId int
  Passport
  {
    Type string
    Number string
  }
Department
  {
    Name string
    Phone string
  }
}
```
**Дополнительно:**
Все методы должны быть реализованы в виде HTTP запросов в формате JSON.
БД: любая.
ORM: Dapper

privet
