#! /bin/bash
echo "Fazendo deploy do backend..."
cd /home/odontrack/application/odon-track-api/Odon.Track
git pull
git checkout 0.0.2
eval $(minikube -p minikube docker-env)
docker build -t app-api-odon-track-image /home/odontrack/application/odon-track-api/Odon.Track
kubectl delete pod -l app=app-api-odon-track
