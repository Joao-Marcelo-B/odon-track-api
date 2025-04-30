#! /bin/bash
cd "$PathOdonTrackWeb"
git checkout develop
git pull
docker build -t app-web-odon-track-image -f Dockerfile-dev "$PathOdonTrackWeb"
kubectl delete pod -l app=app-web-odon-track
