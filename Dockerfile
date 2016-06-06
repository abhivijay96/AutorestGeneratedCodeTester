FROM mono:4.2.3-onbuild
EXPOSE 9000/tcp
CMD [ "mono",  "./TestGenerator.exe" ]