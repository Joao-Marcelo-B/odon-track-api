#! /bin/bash
echo "Fazendo deploy do backend..."
"$DockerClear"
cd "$PathOdonTrackApiPython"
git checkout main
git pull
docker build -t app-odon-track-python-api-image "$PathOdonTrackApiPython"
kubectl delete pod -l app=app-odon-track-python-api
