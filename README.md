## 🐳 Subir imagen a Docker Hub

1. **Hacer login en Docker Hub** (si no lo hiciste ya):

   ```bash
   docker login

2. **Taggear la imagen local** 
   ```bash
   docker tag microservices1:dev elalejmartin/microservices1:dev
   docker tag microservices2:dev elalejmartin/microservices2:dev

3. **Subir la imagen a Docker Hub** 
   ```bash
   docker push elalejmartin/microservices1:dev
   docker push elalejmartin/microservices2:dev
