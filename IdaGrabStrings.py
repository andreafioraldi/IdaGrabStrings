__author__ = "Andrea Fioraldi"
__copyright__ = "Copyright 2017, Andrea Fioraldi"
__license__ = "MIT"
__email__ = "andreafioraldi@gmail.com"

import idaapi
import subprocess
import idc

def startView(buf):
    pass

def fromPosition():
    pass

def fromSelection():
    pass

MENU_PATH = 'Edit/Other'
class IdaGrabStringsPlugin(idaapi.plugin_t):
    flags = idaapi.PLUGIN_KEEP
    comment = ""

    help = "IdaGrabStrings: Grab strings from a bytes buffer in IDA"
    wanted_name = "IDA Grab Strings"

    def init(self):
        r = idaapi.add_menu_item(MENU_PATH, 'IdaGrabStrings - From position', '', 1, fromPosition, tuple())
        if r is None:
            idaapi.msg("IdaGrabStrings: add menu failed!\n")
            return idaapi.PLUGIN_SKIP
        r = idaapi.add_menu_item(MENU_PATH, 'IdaGrabStrings - From selection', '', 1, fromSelection, tuple())
        if r is None:
            idaapi.msg("IdaGrabStrings: add menu failed!\n")
            return idaapi.PLUGIN_SKIP
        idaapi.msg("IdaGrabStrings: initialized\n")
        return idaapi.PLUGIN_KEEP

    def run(self, arg):
        pass

    def term(self):
        idaapi.msg("IdaGrabStrings: terminated\n")


def PLUGIN_ENTRY():
    return IdaGrabStringsPlugin()

