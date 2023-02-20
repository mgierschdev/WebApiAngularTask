FROM node:16-alpine

RUN mkdir -p /frontend

WORKDIR /frontend

COPY package*.json /frontend/

RUN npm install --loglevel verbose

COPY . /frontend/

EXPOSE 4200

CMD ["npm", "start"]