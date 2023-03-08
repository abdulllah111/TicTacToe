# TicTacToe

Приложения для игры в крестики нолики.



## Что требовалось
- Спроектировать и реализовать REST API для игры в крестики нолики;
- Должен поддерживаться формат сообщений json.

## Что было реализовано
- Разработан REST API на платформе .Net7;
- В слоле "persistense" реализована связь с PostgreSql;
- Интегрирован Swagger;
- Использовался паттерн "Mediator", "CQRS".

<br />


## FAQ

### Во первых:
```bash
git clone https://github.com/abdulllah111/TicTacToe.git
```

### Во вторых:

- Настраиваем строку подключения к базе данных (appsettings.json : "DbConnection");
- Запускаем сервер:
```bash
cd TicTacToe/src/Backend/
dotnet run --project Presentation/TicTacToe.WebApi/TicTacToe.WebApi.csproj
```

### В третьих:

Видим ссылку http://localhost:xxxx - Копируем

#### Просмотра возможностей API через swagger:
- В браузере вставляем нашу ссылку и дописываем к ней /swagger/index.html 
- Должно получиться так:  http://localhost:5071/swagger/index.html
 


</br>
</br>
</br>
</br>
</br>

![](https://komarev.com/ghpvc/?username=abdulllah111&color=green&label=Посещений )
