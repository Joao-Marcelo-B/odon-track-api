#! /bin/bash
"$DockerClear"
cd "$PathOdonTrackWeb"
git checkout master
git pull

# Obtém o hash do último commit (curto)
GIT_COMMIT_HASH=$(git -C "$PathOdonTrackWeb" rev-parse --short HEAD)

docker build -t app-web-odon-track-image:"$GIT_COMMIT_HASH" "$PathOdonTrackWeb"
docker tag app-web-odon-track-image:"$GIT_COMMIT_HASH" app-web-odon-track-image:latest

#kubectl set image deployment/app-web-odon-track app-web=app-web-odon-track-image:$GIT_COMMIT_HASH

kubectl delete pod -l app=app-web-odon-track
