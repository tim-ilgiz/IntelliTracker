@echo off
echo Скрипт применяет новую миграцию!
set /P name="Введите название миграции: "

cd ../../../..

dotnet ef migrations add %name% --project Persistence --startup-project WebApi -v