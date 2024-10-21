#! /bin/bash

# Inicializar minikube
echo "=============================================="
if ! minikube status &>/dev/null; then
    minikube start --disk-size=40g --force
else
    echo "O cluster Minikube já está em execução."
fi
# Inicializando proxy
if netstat -tuln | grep ':4200 ' &>/dev/null; then
    echo "A porta 4200 já está em uso."
else
    node "$HOME/server-configs/proxy/proxy-frontend.js" &
    disown
fi

if netstat -tuln | grep ':8080 ' &>/dev/null; then
    echo "A porta 8080 já está em uso."
else
    node "$HOME/server-configs/proxy/proxy-backend.js" &
    disown
fi

if netstat -tuln | grep ':3307' &>/dev/null; then
    echo "A porta 3307 já está em uso."
else
    node "$HOME/server-configs/proxy/proxy-mysql.js" &
    disown
fi
if netstat -tuln | grep ':3000' &>/dev/null; then
    echo "A porta 3000 já está em uso."
else
    node "$HOME/server-configs/proxy/proxy-ngrok.js" &
    disown
    #/home/joaom/ngrok.sh &
fi

#nohup ngrok http --domain=allowing-killdeer-wise.ngrok-free.app 3000 &
echo "=============================================="
