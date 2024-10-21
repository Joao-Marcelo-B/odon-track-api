#! /bin/bash
echo "Fazendo deploy do backend..."
"$PathDockerClear"
cd "$PathOdonTrackApiPython"
git checkout main
git pull
eval $(minikube -p minikube docker-env)
docker build -t app-odon-track-python-api-image "$PathOdonTrackApiPython"
kubectl delete pod -l app=app-odon-track-python-api
