#! /bin/bash
cd "$PathOdonTrackWeb"
git pull
git checkout $(git describe --tags `git rev-list --tags --max-count=1`)
eval $(minikube -p minikube docker-env)
docker build -t app-web-odon-track-image "$PathOdonTrackWeb"
kubectl delete pod -l app=app-web-odon-track
