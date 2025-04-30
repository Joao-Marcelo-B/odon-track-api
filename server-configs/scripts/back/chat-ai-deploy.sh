#! /bin/bash
echo "Fazendo deploy do backend..."
"$DockerClear"
cd "$PathOdonTrackChatAIApi"
git checkout main
git pull
docker build -t app-odon-track-chat-ai-api-image "$PathOdonTrackChatAIApi"
kubectl delete pod -l app=app-odon-track-chat-ai-api
