#! /bin/bash
cd "$PathOdonTrackWeb"
git checkout develop
git pull
eval $(minikube -p minikube docker-env)
docker build -t app-web-odon-track-image "$PathOdonTrackWeb"
kubectl delete pod -l app=app-web-odon-track
