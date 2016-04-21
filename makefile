LOGINY=xvichs00_xturec06_xsmajz00_xmuzik05
DOXY=Doxyfile

pack: clean
	zip -r $(LOGINY).zip *
clean:
	rm -fR Calc/bin/Debug/*.exe
doc:
	doxygen $(DOXY)
