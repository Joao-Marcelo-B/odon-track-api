#! /bin/bash

cd "$PathOdonTrackApi"
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml

cd "$PathOdonTrackApiPython"
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml

cd "$PathOdonTrackWeb"
kubectl apply -f deployment.yaml
kubectl apply -f service.yaml

cd "$PathOdonTrackMySQL"
kubectl apply -f deployment.yaml