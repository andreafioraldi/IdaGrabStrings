__author__ = "Andrea Fioraldi"
__copyright__ = "Copyright 2017, Andrea Fioraldi"
__license__ = "MIT"
__email__ = "andreafioraldi@gmail.com"

import idaapi
import subprocess
import idc
import os

pwd = os.path.dirname(__file__)

def startView(buf):
    pass

def fromPosition():
    pos = idc.ScreenEA()
    view = subprocess.Popen(
        [os.path.join(pwd, "IdaGrabStringsView.exe"), "0", "0x"+hex(pos)],
        stdout=subprocess.PIPE,
        stdin=subprocess.PIPE
        )
    output = view.communicate()[0]
    lines = output.split("\n")
    try:
        buf = idc.GetManyBytes(int(lines[0]), int(lines[1]), False)
        startView(buf)
    except Exception as ex:
        idaapi.msg("IdaGrabStrings: fromPosition error: "+ex.message+"\n")

def fromSelection():
    pass
                            

MENU_PATH = 'Edit/Other'
class IdaGrabStringsPlugin(idaapi.plugin_t):
    flags = idaapi.PLUGIN_KEEP
    comment = ""

    help = "IdaGrabStrings: Grab strings from a bytes buffer in IDA"
    wanted_name = "IDA Grab Strings"
    wanted_hotkey = "Alt-8"
    
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

