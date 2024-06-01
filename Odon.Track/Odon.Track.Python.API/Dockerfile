FROM python:3.9-slim

WORKDIR /app

RUN pip install --upgrade pip
RUN pip install flask

COPY . .

EXPOSE 5000

CMD ["python" , "Controllers.py"]
