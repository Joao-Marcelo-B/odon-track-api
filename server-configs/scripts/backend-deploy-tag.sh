#! /bin/bash
echo "Fazendo deploy do backend..."
cd "$PathOdonTrackApi"
git pull
git checkout 0.0.2
eval $(minikube -p minikube docker-env)
docker build -t app-api-odon-track-image "$PathOdonTrackApi"
kubectl delete pod -l app=app-api-odon-track
