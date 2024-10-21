#! /bin/bash
echo "Fazendo deploy do backend..."
"$DockerClear"
cd "$PathOdonTrackApi"
git checkout main
git pull
eval $(minikube -p minikube docker-env)
docker build -t app-api-odon-track-image "$PathOdonTrackApi"
kubectl delete pod -l app=app-api-odon-track