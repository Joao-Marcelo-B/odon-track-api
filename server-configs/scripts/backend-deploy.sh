#! /bin/bash
echo "Fazendo deploy do backend..."
"$DockerClear"
cd "$PathOdonTrackApi"
git checkout main
git pull
docker build -t app-api-odon-track-image "$PathOdonTrackApi"
sudo ctr images pull app-api-odon-track-image:latest
kubectl delete pod -l app=app-api-odon-track
