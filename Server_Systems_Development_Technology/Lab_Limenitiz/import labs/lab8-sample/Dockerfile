FROM adoptopenjdk/openjdk14:alpine
COPY target/lb2-0.0.1-SNAPSHOT.jar app.jar
ENTRYPOINT [ "sh", "-c", "java -jar app.jar" ]