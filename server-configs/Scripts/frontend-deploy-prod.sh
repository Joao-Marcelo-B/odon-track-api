#! /bin/bash
/home/odontrack/server-configs/Scripts/docker-clear.sh
cd /home/odontrack/application/odon-track
git checkout master
git pull
eval $(minikube -p minikube docker-env)
docker build -t app-web-odon-track-image -f Dockerfile-prod /home/odontrack/application/odon-track
kubectl delete pod -l app=app-web-odon-track
