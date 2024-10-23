﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitono
{
    public static class German
    {
        public static Dictionary<string, string> german = new Dictionary<string, string>() {
            {"if", "wenn"},
            {"elif", "elif"},
            {"else", "anders"},
            {"print", "drucken"},
            {"float", "schweben"},
            {"input", "eingang"},
            {"str", "str"},
            {"string", "zeichenfolge"},
            {"def", "def"},
            {"assert", "behaupten"},
            {"exit", "ausfahrt"},
            {"close", "schließen"},
            {"quit", "aufhören"},
            {"return", "zurückkehren"},
            {"for", "für"},
            {"in", "In"},
            {"range", "Reichweite"},
            {"len", "len"},
            {"import", "Import"},
            {"raise", "erheben"},
            {"module", "Modul"},
            {"aclose", "nah_dran"},
            {"True", "Wahr"},
            {"False", "Falsch"},
            {"true", "wahr"},
            {"false", "falsch"},
            {"while", "während"},
            {"not", "nicht"},
            {"and", "Und"},
            {"del", "del"},
            {"fdel", "fdel"},
            {"or", "oder"},
            {"get", "erhalten"},
            {"fget", "fget"},
            {"break", "brechen"},
            {"__init__", "__init__"},
            {"__init_subclass__", "__init_subclass__"},
            {"from", "aus"},
            {"as", "als"},
            {"removesuffix", "Suffix_entfernen"},
            {"suffix", "Suffix"},
            {"removeprefix", "Präfix_entfernen"},
            {"prefix", "Präfix"},
            {"remove", "entfernen"},
            {"title", "Titel"},
            {"upper", "obere"},
            {"lower", "untere"},
            {"append", "anhängen"},
            {"clear", "klar"},
            {"pop", "Pop"},
            {"popitem", "Popitem"},
            {"shift", "Schicht"},
            {"lshift", "lshift"},
            {"__lshift__", "__lshift__"},
            {"__rlshift__", "__rlshift__"},
            {"__ilshift__", "__ilshift__"},
            {"rshift", "rshift"},
            {"__rshift__", "__rshift__"},
            {"__rrshift__", "__rrshift__"},
            {"__irshift__", "__irshift__"},
            {"unshift", "unshift"},
            {"insert", "einfügen"},
            {"slice", "Scheibe"},
            {"rstrip", "rstrip"},
            {"lstrip", "lstrip"},
            {"strip", "Streifen"},
            {"self", "selbst"},
            {"this", "Das"},
            {"list", "Liste"},
            {"lists", "Listen"},
            {"sorted", "sortiert"},
            {"sort", "Sortieren"},
            {"reverse", "umkehren"},
            {"__invert__", "__umkehren__"},
            {"min", "min"},
            {"max", "max"},
            {"sum", "Summe"},
            {"key", "Schlüssel"},
            {"keys", "Mehrere_Schlüssel"},
            {"only_keys", "only_keys"},
            {"fromkeys", "fromkeys"},
            {"fromlines", "fromlines"},
            {"__name__", "__Name__"},
            {"__qualname__", "__qualname__"},
            {"__module__", "__Modul__"},
            {"__defaults__", "__Standards__"},
            {"defaults", "Standardwerte"},
            {"__code__", "__Code__"},
            {"code", "Code"},
            {"__kwdefaults__", "__kwdefaults__"},
            {"type", "Typ"},
            {"__type_params__", "__type_params__"},
            {"__self__", "__selbst__"},
            {"__func__", "__func__"},
            {"__next__", "__nächste__"},
            {"__anext__", "__next__"},
            {"__new__", "__neu__"},
            {"__call__", "__Anruf__"},
            {"__import__", "__Import__"},
            {"__file__", "__Datei__"},
            {"__bases__", "__Basen__"},
            {"__bytes__", "__Byte__"},
            {"bases", "Basen"},
            {"__mro__", "__mro__"},
            {"mro", "mro"},
            {"__subclasses__", "__Unterklassen__"},
            {"__subclass__", "__Unterklasse__"},
            {"subclass", "Unterklasse"},
            {"subclasses", "Unterklassen"},
            {"line", "Linie"},
            {"cache", "Cache"},
            {"no_cache", "no_cache"},
            {"clear_cache", "clear_cache"},
            {"make_file", "make_file"},
            {"make_table", "make_table"},
            {"fobj", "fobj"},
            {"file", "datei"},
            {"File", "Datei"},
            {"__getattr__", "__getattr__"},
            {"__get__", "__erhalten__"},
            {"__getitem__", "__artikel_erhalten__"},
            {"__getitems__", "__mehrere_artikel_erhalten__"},
            {"__delitem__", "__element_löschen__"},
            {"__delitems__", "__mehrere_elemente_löschen__"},
            {"__setitem__", "__setitem__"},
            {"__set__", "__Satz__"},
            {"__set_name_", "__set_name_"},
            {"__setitems__", "__setitems__"},
            {"__getattribute__", "__getattribute__"},
            {"getattribute", "getattribute"},
            {"getattr", "getattr"},
            {"get_close_matches", "get_close_matches"},
            {"get_matching_blocks", "get_matching_blocks"},
            {"__setattr__", "__setattr__"},
            {"setattr", "setattr"},
            {"complex", "Komplex"},
            {"__complex__", "__Komplex__"},
            {"conjugate", "konjugieren"},
            {"abs", "absoluter_wert"},
            {"__abs__", "__absoluter_wert__"},
            {"divmod", "divmod"},
            {"__divmod__", "__divmod__"},
            {"__rdivmod__", "__rdivmod__"},
            {"enumerate", "aufzählen"},
            {"enum", "Aufzählung"},
            {"IntEnum", "IntEnum"},
            {"_constants", "_Konstanten"},
            {"constants", "Konstanten"},
            {"constant", "Konstante"},
            {"_NamedIntConstant", "_NamedIntConstant"},
            {"named", "namens"},
            {"aiter", "aiter"},
            {"__aiter__", "__aiter__"},
            {"aenter", "eintreten"},
            {"__aenter__", "__aenter__"},
            {"iterator", "iterator"},
            {"Iterator", "Iterator"},
            {"iterators", "Iteratoren"},
            {"all", "alle"},
            {"any", "beliebig"},
            {"bin", "Mülleimer"},
            {"bool", "bool"},
            {"__bool__", "__bool__"},
            {"breakpoint", "Haltepunkt"},
            {"bytearray", "Bytearray"},
            {"bytes", "Bytes"},
            {"byte", "Byte"},
            {"callable", "abrufbar"},
            {"pow", "pow"},
            {"__pow__", "__pow__"},
            {"__rpow__", "__rpow__"},
            {"__ipow__", "__ipow__"},
            {"chr", "chr"},
            {"char", "verkohlen"},
            {"charset", "Zeichensatz"},
            {"chars", "Buchstaben"},
            {"function", "Funktion"},
            {"search_function", "Suchfunktion"},
            {"desinscribir", "desinskriptiren"},
            {"EncodedFile", "EncodedFile"},
            {"classmethod", "Klassenmethode"},
            {"compile", "kompilieren"},
            {"delattr", "delattr"},
            {"__delattr__", "__delattr__"},
            {"__delete__", "__löschen__"},
            {"__objclass__", "__objclass__"},
            {"dir", "dir"},
            {"directory", "Verzeichnis"},
            {"eval", "evalu"},
            {"exec", "Geschäftsführer"},
            {"event", "Ereignis"},
            {"filter", "Filter"},
            {"format", "Format"},
            {"vformat", "vformat"},
            {"__format__", "__Format__"},
            {"hasattr", "hasattr"},
            {"__hasattr__", "__hasattr__"},
            {"hash", "Hash"},
            {"__hash__", "__hash__"},
            {"hashable", "hashbar"},
            {"Hashable", "Hashbar"},
            {"help", "helfen"},
            {"hex", "verhexen"},
            {"id", "Ausweis"},
            {"instance", "Beispiel"},
            {"instances", "Instanzen"},
            {"isinstance", "ist_eine_Instanz"},
            {"__instancecheck__", "__instancecheck__"},
            {"__subclasscheck__", "__subclasscheck__"},
            {"issubclass", "issubclass"},
            {"issubset", "issubset"},
            {"subset", "Teilmenge"},
            {"iter", "iter"},
            {"locals", "Einheimische"},
            {"local", "lokal"},
            {"map", "Karte"},
            {"next", "nächste"},
            {"object", "Objekt"},
            {"obj", "obj"},
            {"objects", "Objekte"},
            {"oct", "Okt"},
            {"open", "offen"},
            {"ord", "ord"},
            {"unicode", "Unicode"},
            {"unicodedata", "Unicodedaten"},
            {"property", "Eigentum"},
            {"__slots__", "__Slots__"},
            {"__weakref__", "__weakref__"},
            {"weakref", "schwachref"},
            {"getter", "Getter"},
            {"setter", "Setter"},
            {"deleter", "Löscher"},
            {"repr", "repr"},
            {"__repr__", "__repr__"},
            {"reversed", "umgedreht"},
            {"round", "runden"},
            {"__round__", "__runden__"},
            {"trunc", "abschneiden"},
            {"__trunc__", "__trunc__"},
            {"__floor__", "__Boden__"},
            {"floor", "Boden"},
            {"__ceil__", "__ceil__"},
            {"ceil", "Decke"},
            {"start", "Start"},
            {"stop", "stoppen"},
            {"reset", "zurücksetzen"},
            {"getstate", "getstate"},
            {"setstate", "setstate"},
            {"step", "Schritt"},
            {"static", "statisch"},
            {"staticmethod", "statische_Methode"},
            {"method", "Verfahren"},
            {"errors", "mehrere_fehler"},
            {"error", "Fehler"},
            {"error_handler", "error_handler"},
            {"idna", "idna"},
            {"encoding", "Codierung"},
            {"encodings", "Kodierungen"},
            {"data_encoding", "data_encoding"},
            {"file_encoding", "file_encoding"},
            {"encode", "kodieren"},
            {"encoder", "Encoder"},
            {"incrementalencoder", "Inkrementalencoder"},
            {"IncrementalEncoder", "InkrementalEncoder"},
            {"getencoder", "getencoder"},
            {"getincrementalencoder", "getinkrementalencoder"},
            {"decoding", "Dekodierung"},
            {"decode", "dekodieren"},
            {"decoder", "Decoder"},
            {"incrementaldecoder", "Inkrementaldecoder"},
            {"IncrementalDecoder", "InkrementalDecoder"},
            {"getdecoder", "getdecoder"},
            {"getincrementaldecoder", "getincrementaldecoder"},
            {"iterable", "iterierbar"},
            {"Iterable", "Iterierbar"},
            {"async_iterable", "async_iterable"},
            {"AsyncIterable", "AsyncIterable"},
            {"iterables", "iterierbare_Elemente"},
            {"async_iterables", "async_iterables"},
            {"async_iterator", "async_iterator"},
            {"AsyncIterator", "AsyncIterator"},
            {"async_iterators", "async_iterators"},
            {"async_generator", "async_generator"},
            {"async_generators", "async_generators"},
            {"AsyncGenerator", "AsyncGenerator"},
            {"object_or_type", "Objekt_oder_Typ"},
            {"super", "super"},
            {"tuple", "Tupel"},
            {"kwds", "kwds"},
            {"kwd", "kwd"},
            {"kws", "kws"},
            {"kw", "kw"},
            {"kwarg", "kwarg"},
            {"kwargs", "kwargs"},
            {"arg", "arg"},
            {"args", "args"},
            {"__args__", "__args__"},
            {"vars", "Vars"},
            {"strict", "strikt"},
            {"zip", "Reißverschluss"},
            {"fromlist", "fromlist"},
            {"level", "Ebene"},
            {"source", "Quelle"},
            {"filename", "Dateiname"},
            {"mode", "Modus"},
            {"abiflags", "abiflags"},
            {"addaudithook", "addaudithook"},
            {"hook", "Haken"},
            {"argv", "argv"},
            {"audit", "Prüfung"},
            {"base_exec_prefix", "base_exec_prefix"},
            {"base_prefix", "base_prefix"},
            {"builtin_module_names", "eingebaute_Modulnamen"},
            {"call_tracing", "call_tracing"},
            {"_clear_type_cache", "_clear_type_cache"},
            {"_current_frames", "_aktuelle_Frames"},
            {"_current_exceptions", "_aktuelle_Ausnahmen"},
            {"breakpointhook", "Haltepunkthaken"},
            {"flags", "Flaggen"},
            {"flag", "Flagge"},
            {"IntFlag", "IntFlag"},
            {"dont_inherit", "dont_inherit"},
            {"inherit", "erben"},
            {"optimize", "optimieren"},
            {"textwrap", "Textumbruch"},
            {"wrap", "wickeln"},
            {"text", "Text"},
            {"number", "Nummer"},
            {"word", "Wort"},
            {"possibilities", "Möglichkeiten"},
            {"cutoff", "Abschaltung"},
            {"ndiff", "ndiff"},
            {"imag", "Bild"},
            {"complexvalue", "komplexer_Wert"},
            {"floatvalue", "Float_Wert"},
            {"sign", "Zeichen"},
            {"absfloatvalue", "Absfloatwert"},
            {"__float__", "__schweben__"},
            {"__int__", "__int__"},
            {"__index__", "__Index__"},
            {"index", "Index"},
            {"lastindex", "lastindex"},
            {"lastgroup", "letzte_Gruppe"},
            {"indices", "Indizes"},
            {"mapping", "Abbildung"},
            {"mappingproxy", "Mappingproxy"},
            {"__dir__", "__dir__"},
            {"expression", "Ausdruck"},
            {"infinity", "Unendlichkeit"},
            {"nan", "Nan"},
            {"digit", "Ziffer"},
            {"digits", "Ziffern"},
            {"digitpart", "Ziffernteil"},
            {"exponent", "Exponent"},
            {"exp", "exp"},
            {"format_spec", "format_spec"},
            {"default", "Standard"},
            {"setdefault", "setdefault"},
            {"prompt", "prompt"},
            {"base", "Base"},
            {"classinfo", "Klasseninfo"},
            {"sentinel", "Wächter"},
            {"arg1", "arg1"},
            {"arg2", "arg2"},
            {"arg3", "arg3"},
            {"arg4", "arg4"},
            {"arg5", "arg5"},
            {"offset", "versetzt"},
            {"unpack", "auspacken"},
            {"unpack_from", "unpack_from"},
            {"iter_unpack", "iter_unpack"},
            {"calcsize", "berechnen"},
            {"codec", "Codec"},
            {"codecs", "Codecs"},
            {"CodecInfo", "CodecInfo"},
            {"write", "schreiben"},
            {"writelines", "Schreibzeilen"},
            {"read", "lesen"},
            {"stream", "Strom"},
            {"streamreader", "Streamreader"},
            {"StreamReader", "StreamReader"},
            {"Reader", "Leser"},
            {"Writer", "Schriftsteller"},
            {"StreamRecoder", "StreamRecoder"},
            {"StreamReaderWriter", "StreamReaderWriter"},
            {"getreader", "getreader"},
            {"streamwriter", "Streamwriter"},
            {"StreamWriter", "StreamWriter"},
            {"getwriter", "getwriter"},
            {"newline", "Zeilenumbruch"},
            {"closefd", "closefd"},
            {"write_through", "write_through"},
            {"opener", "Öffner"},
            {"modulo", "Modulo"},
            {"modulus", "Modulus"},
            {"mod", "Mod"},
            {"inv_base", "inv_base"},
            {"sep", "sep"},
            {"bytes_per_sep", "bytes_per_sep"},
            {"seperate", "separate"},
            {"end", "Ende"},
            {"ends", "endet"},
            {"flush", "spülen"},
            {"seq", "seq"},
            {"which", "welche"},
            {"sequence", "sequenz"},
            {"Sequence", "Sequenz"},
            {"SequenceMatcher", "SequenceMatcher"},
            {"Differ", "Abweichen"},
            {"HtmlDiff", "HtmlDiff"},
            {"wrapcolumn", "Wrapcolumn"},
            {"linejunk", "Linejunk"},
            {"isjunk", "ist_Schrott"},
            {"autojunk", "Automüll"},
            {"set_seqs", "set_seqs"},
            {"set_seq1", "set_seq1"},
            {"set_seq2", "set_seq2"},
            {"find_longest_match", "find_longest_match"},
            {"alo", "Alo"},
            {"ahi", "Ahi"},
            {"blo", "blo"},
            {"bhi", "Bhi"},
            {"charjunk", "Charjunk"},
            {"IS_CHARACTER_JUNK", "IS_CHARACTER_JUNK"},
            {"MutableSequence", "MutableSequence"},
            {"ndigits", "nZiffern"},
            {"ndigit", "ndigit"},
            {"restore", "wiederherstellen"},
            {"bit_length", "bit_länge"},
            {"bit_count", "bit_count"},
            {"new_itemsize", "new_itemsize"},
            {"itemsize", "Artikelgröße"},
            {"count", "zählen"},
            {"to_bytes", "to_bytes"},
            {"tobytes", "Tobyte"},
            {"from_bytes", "from_bytes"},
            {"length", "Länge"},
            {"byte_length", "Bytelänge"},
            {"byteorder", "Bytereihenfolge"},
            {"order", "Befehl"},
            {"signed", "unterzeichnet"},
            {"as_integer_ratio", "as_integer_ratio"},
            {"is_integer", "is_integer"},
            {"fromhex", "fromhex"},
            {"fraction", "Fraktion"},
            {"fractions", "Brüche"},
            {"hash_fraction", "hash_fraction"},
            {"hash_float", "hash_float"},
            {"hash_complex", "hash_complex"},
            {"hash_value", "hash_value"},
            {"__iter__", "__iter__"},
            {"join", "verbinden"},
            {"copy", "Kopie"},
            {"copyright", "Copyright"},
            {"credits", "Credits"},
            {"license", "Lizenz"},
            {"extend", "verlängern"},
            {"capitalize", "profitieren"},
            {"casefold", "Fallfalte"},
            {"doblar", "doblar"},
            {"center", "Center"},
            {"sys", "sys"},
            {"_debugmallocstats", "_debugmallocstats"},
            {"dllhandle", "dllhandle"},
            {"displayhook", "Anzeigehaken"},
            {"dont_write_bytecode", "dont_write_bytecode"},
            {"_emscripten_info", "_emscripten_info"},
            {"emscripten_version", "Emscripten_Version"},
            {"runtime", "Laufzeit"},
            {"pthreads", "pthreads"},
            {"shared_memory", "shared_memory"},
            {"pycache_prefix", "pycache_prefix"},
            {"excepthook", "außerhook"},
            {"__breakpointhook__", "__breakpointhook__"},
            {"__displayhook__", "__displayhook__"},
            {"__excepthook__", "__außerhook__"},
            {"__unraisablehook__", "__unraisablehook__"},
            {"exc_info", "exc_info"},
            {"exec_prefix", "exec_prefix"},
            {"executable", "ausführbar"},
            {"inspect", "überprüfen"},
            {"interactive", "interaktiv"},
            {"isolated", "isoliert"},
            {"no_user_site", "no_user_site"},
            {"no_site", "no_site"},
            {"ignore_environment", "ignorieren_umgebung"},
            {"bytes_warning", "bytes_warning"},
            {"quiet", "ruhig"},
            {"hash_randomization", "hash_randomization"},
            {"dev_mode", "dev_mode"},
            {"utf8_mode", "utf8_mode"},
            {"safe_path", "sicherer_Pfad"},
            {"warn_default_encoding", "warn_default_encoding"},
            {"float_info", "float_info"},
            {"epsilon", "Epsilon"},
            {"dig", "graben"},
            {"mant_dig", "mant_dig"},
            {"max_exp", "max_exp"},
            {"max_10_exp", "max_10_exp"},
            {"min_exp", "min_exp"},
            {"min_10_exp", "min_10_exp"},
            {"radix", "Wurzel"},
            {"rounds", "Runden"},
            {"float_repr_style", "float_repr_style"},
            {"getallocatedblocks", "getallocatedblocks"},
            {"getunicodeinternedsize", "getunicodeinternedsize"},
            {"getandroidapilevel", "tandroidapilevel"},
            {"getdefaultencoding", "getdefaultencoding"},
            {"getdlopenflags", "getdlopenflags"},
            {"getfilesystemencoding", "getfilesystemencoding"},
            {"getfilesystemencodeerrors", "getfilesystemencodeerrors"},
            {"get_int_max_str_digits", "get_int_max_str_digits"},
            {"getrefcount", "getrefcount"},
            {"getrecursionlimit", "getrecursionlimit"},
            {"getsizeof", "getsizeof"},
            {"getswitchinterval", "getswitchinterval"},
            {"_getframe", "_getframe"},
            {"depth", "Tiefe"},
            {"_getframemodulename", "_getframe_Modulname"},
            {"getprofile", "getprofile"},
            {"gettrace", "gettrace"},
            {"getwindowsversion", "getwindowsversion"},
            {"get_asyncgen_hooks", "get_asyncgen_hooks"},
            {"get_coroutine_origin_tracking_depth", "get_coroutine_origin_tracking__Depth"},
            {"hash_info", "hash_info"},
            {"inf", "inf"},
            {"algorithm", "Algorithmus"},
            {"hash_bits", "hash_bits"},
            {"seed_bits", "Seed_bits"},
            {"hexversion", "Hexversion"},
            {"implementation", "Durchführung"},
            {"int_info", "int_info"},
            {"bits_per_digit", "bits_per_digit"},
            {"sizeof_digit", "sizeof_digit"},
            {"default_max_str_digits", "default_max_str_digits"},
            {"str_digits_check_threshold", "str_digits_check_threshold"},
            {"__interactivehook__", "__interactivehook__"},
            {"intern", "Praktikant"},
            {"_is_gil_enabled", "_is_gil_enabled"},
            {"is_finalizing", "is_finalizing"},
            {"last_exc", "last_exc"},
            {"_is_interned", "_ist_interniert"},
            {"last_type", "last_type"},
            {"last_value", "last_value"},
            {"last_traceback", "last_traceback"},
            {"maxsize", "maximale_Größe"},
            {"maxunicode", "maxunicode"},
            {"meta_path", "meta_path"},
            {"modules", "Module"},
            {"orig_argv", "orig_argv"},
            {"path_hooks", "path_hooks"},
            {"path_importer_cache", "path_importer_cache"},
            {"platform", "Plattform"},
            {"platlibdir", "platlibdir"},
            {"ps1", "ps1"},
            {"ps2", "ps2"},
            {"setdlopenflags", "setdlopenflags"},
            {"set_int_max_str_digits", "set_int_max_str_digits"},
            {"setprofile", "setprofile"},
            {"profilefunc", "Profilfunktion"},
            {"maxdigits", "maxdigits"},
            {"setrecursionlimit", "setrecursionlimit"},
            {"limit", "Limit"},
            {"setswitchinterval", "setswitchinterval"},
            {"interval", "Intervall"},
            {"settrace", "settrace"},
            {"tracefunc", "Tracefunc"},
            {"set_asyncgen_hooks", "set_asyncgen_hooks"},
            {"firstiter", "Erstling"},
            {"finalizer", "Finalisierer"},
            {"set_coroutine_origin_tracking_depth", "set_coroutine_origin_tracking__Depth"},
            {"activate_stack_trampoline", "activate_stack_trampoline"},
            {"backend", "Backend"},
            {"deactivate_stack_trampoline", "Stapeltrampolin_deaktivieren"},
            {"is_stack_trampoline_active", "is_stack_trampoline_active"},
            {"_enablelegacywindowsfsencoding", "_enablelegacywindowsfsencoding"},
            {"stdout", "stdout"},
            {"stdin", "stdin"},
            {"stderr", "stderr"},
            {"__stdin__", "__stdin__"},
            {"__stderr__", "__stderr__"},
            {"__stdout__", "__stdout__"},
            {"stdlib_module_names", "stdlib_module_names"},
            {"thread_info", "thread_info"},
            {"lock", "sperren"},
            {"version", "Version"},
            {"tracebacklimit", "Tracebacklimit"},
            {"unraisablehook", "unraisablehook"},
            {"unraisable", "nicht_erhebbar"},
            {"api_version", "api_version"},
            {"version_info", "version_info"},
            {"warnoptions", "Warnoptionen"},
            {"winver", "winver"},
            {"monitoring", "Überwachung"},
            {"_xoptions", "_xoptions"},
            {"asctime", "Asctime"},
            {"pthread_getcpuclockid", "pthread_getcpuclockid"},
            {"thread_id", "thread_id"},
            {"clock_getres", "clock_getres"},
            {"clk_id", "clk_id"},
            {"clock_gettime", "clock_gettime"},
            {"clock_gettime_ns", "clock_gettime_ns"},
            {"clock_settime", "clock_settime"},
            {"clock_settime_ns", "clock_settime_ns"},
            {"secs", "Sekunden"},
            {"get_clock_info", "get_clock_info"},
            {"gmtime", "gmtime"},
            {"localtime", "Ortszeit"},
            {"mktime", "mktime"},
            {"monotonic", "monoton"},
            {"monotonic_ns", "monotonic_ns"},
            {"perf_counter", "perf_counter"},
            {"perf_counter_ns", "perf_counter_ns"},
            {"process_time", "Prozesszeit"},
            {"process_time_ns", "Prozesszeit_ns"},
            {"sleep", "schlafen"},
            {"strftime", "strftime"},
            {"strptime", "strptime"},
            {"struct_time", "struct_time"},
            {"tm_year", "tm_year"},
            {"tm_mon", "tm_mon"},
            {"tm_mday", "tm_mday"},
            {"tm_hour", "tm_hour"},
            {"tm_min", "tm_min"},
            {"tm_sec", "tm_sec"},
            {"tm_wday", "tm_wday"},
            {"tm_yday", "tm_yday"},
            {"tm_isdst", "tm_isdst"},
            {"tm_zone", "tm_zone"},
            {"tm_gmtoff", "tm_gmtoff"},
            {"time_ns", "time_ns"},
            {"thread_time", "thread_time"},
            {"thread_time_ns", "thread_time_ns"},
            {"tzset", "tzset"},
            {"CLOCK_BOOTTIME", "CLOCK_BOOTTIME"},
            {"CLOCK_HIGHRES", "CLOCK_HIGHRES"},
            {"CLOCK_MONOTONIC", "CLOCK_MONOTONIC"},
            {"CLOCK_MONOTONIC_RAW", "CLOCK_MONOTONIC_RAW"},
            {"CLOCK_MONOTONIC_RAW_APPROX", "CLOCK_MONOTONIC_RAW_APPROX"},
            {"CLOCK_PROCESS_CPUTIME_ID", "CLOCK_PROCESS_CPUTIME_ID"},
            {"CLOCK_PROF", "CLOCK_PROF"},
            {"CLOCK_TAI", "CLOCK_TAI"},
            {"CLOCK_THREAD_CPUTIME_ID", "CLOCK_THREAD_CPUTIME_ID"},
            {"CLOCK_UPTIME", "CLOCK_UPTIME"},
            {"CLOCK_UPTIME_RAW", "CLOCK_UPTIME_RAW"},
            {"CLOCK_UPTIME_RAW_APPROX", "CLOCK_UPTIME_RAW_APPROX"},
            {"CLOCK_REALTIME", "CLOCK_REALTIME"},
            {"altzone", "altzone"},
            {"daylight", "Tageslicht"},
            {"random", "zufällig"},
            {"seed", "Samen"},
            {"randbytes", "Randbyte"},
            {"randrange", "Randbereich"},
            {"randint", "Randint"},
            {"getrandbits", "getrandbits"},
            {"choice", "Auswahl"},
            {"choices", "Entscheidungen"},
            {"population", "Bevölkerung"},
            {"weights", "Gewichte"},
            {"cum_weights", "cum_weights"},
            {"shuffle", "Shuffle"},
            {"sample", "Probe"},
            {"counts", "zählt"},
            {"binomialvariate", "Binomialvariable"},
            {"uniform", "Uniform"},
            {"triangular", "dreieckig"},
            {"low", "niedrig"},
            {"high", "hoch"},
            {"betavariate", "Betavariate"},
            {"alpha", "Alpha"},
            {"beta", "Beta"},
            {"expovariate", "expovariat"},
            {"lambd", "Lambda"},
            {"gammavariate", "Gammavariate"},
            {"gauss", "Gauß"},
            {"sigma", "Sigma"},
            {"mu", "mu"},
            {"lognormvariate", "lognormvariate"},
            {"normalvariate", "Normalvariate"},
            {"vonmisesvariate", "vonmisesvariate"},
            {"kappa", "Kappa"},
            {"paretovariate", "Paretovariate"},
            {"weibullvariate", "weibullvariate"},
            {"Random", "Zufällig"},
            {"SystemRandom", "SystemZufällig"},
            {"ArithmeticError", "ArithmeticError"},
            {"AssertionError", "Behauptungsfehler"},
            {"AttributeError", "AttributeError"},
            {"Exception", "Ausnahme"},
            {"EOFError", "EOFError"},
            {"FloatingPointError", "FloatingPointError"},
            {"GeneratorExit", "GeneratorExit"},
            {"IllegalMonthError", "IllegalMonthError"},
            {"IllegalWeekdayError", "IllegalWeekdayError"},
            {"ImportError", "Importfehler"},
            {"IndentationError", "Einrückungsfehler"},
            {"IndexError", "Indexfehler"},
            {"InvalidTZPathWarning", "Ungültige_TZPathWarning"},
            {"KeyError", "Schlüsselfehler"},
            {"KeyboardInterrupt", "KeyboardInterrupt"},
            {"LookupError", "LookupError"},
            {"MemoryError", "Speicherfehler"},
            {"NameError", "Namensfehler"},
            {"NotImplementedError", "NotImplementedError"},
            {"OSError", "OSError"},
            {"OverflowError", "Überlauffehler"},
            {"ReferenceError", "Referenzfehler"},
            {"RuntimeError", "Laufzeitfehler"},
            {"StopIteration", "StopIteration"},
            {"StopAsyncIteration", "StopAsyncIteration"},
            {"SyntaxError", "Syntaxfehler"},
            {"TabError", "TabError"},
            {"SystemError", "Systemfehler"},
            {"SystemExit", "SystemExit"},
            {"TypeError", "TypeError"},
            {"UnboundLocalError", "UnboundLocalError"},
            {"UnicodeError", "Unicode_Fehler"},
            {"UnicodeEncodeError", "UnicodeEncodeError"},
            {"UnicodeDecodeError", "UnicodeDecodeError"},
            {"UnicodeTranslateError", "UnicodeTranslateError"},
            {"ValueError", "Wertfehler"},
            {"ZeroDivisionError", "ZeroDivisionError"},
            {"ZoneInfoNotFoundError", "ZoneInfoNotFoundError"}
        };
    }
}
