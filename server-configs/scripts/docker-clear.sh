#! /bin/bash
eval $(minikube -p minikube docker-env)
docker image prune -f
docker system prune -f
