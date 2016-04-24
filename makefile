LOGINY=xvichs00_xturec06_xsmajz00_xmuzik05
DOXY=Doxyfile

pack:
	zip -r $(LOGINY).zip *

doc:
	doxygen $(DOXY)