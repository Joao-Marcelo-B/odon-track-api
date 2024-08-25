#! /bin/bash
cd /home/joaom/OdonTrack/odon-track
git checkout develop
git pull
eval $(minikube -p minikube docker-env)
docker build -t app-web-odon-track-image /home/joaom/OdonTrack/odon-track
kubectl delete pod -l app=app-web-odon-track
