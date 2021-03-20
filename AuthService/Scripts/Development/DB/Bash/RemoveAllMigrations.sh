#!/bin/bash 

#Реверт миграций
dotnet ef database update 0 --project Persistence --startup-project WebApi

#Удаление миграций
dotnet ef migrations remove --project Persistence --startup-project WebApi