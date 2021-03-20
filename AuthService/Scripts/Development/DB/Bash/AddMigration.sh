#!/bin/bash 
	
echo Введите название миграции:
 
read name

cd ../../..

dotnet ef migrations add $name --project Persistence --startup-project WebApi -v