@echo off
echo Скрипт обновляет базу данных!

cd ../../../..

dotnet ef database update --project Persistence --startup-project WebApi -v