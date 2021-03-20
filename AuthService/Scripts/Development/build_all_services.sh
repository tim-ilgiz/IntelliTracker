#!/bin/bash

export UID=$(id -u)
export GID=$(id -g)
cd ..
docker-compose -f docker-compose.yml -f docker-compose.dev.yml build

