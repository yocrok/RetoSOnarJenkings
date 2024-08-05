FROM mono:latest
RUN mkdir /opt/app
COPY cargauma /opt/app
CMD ["mono", "/opt/app/cargauma"]