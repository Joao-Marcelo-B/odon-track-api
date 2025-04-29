#! /bin/bash
"$DockerClear"
cd "$PathOdonTrackWeb"
git checkout master
git pull
docker build -t app-web-odon-track-image -f Dockerfile-prod "$PathOdonTrackWeb"
kubectl delete pod -l app=app-web-odon-track
