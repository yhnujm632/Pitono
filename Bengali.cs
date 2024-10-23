﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitono
{
    public static class Bengali
    {
        public static Dictionary<string, string> bengali = new Dictionary<string, string>() {
            {"if", "যদি"},
            {"elif", "এলিফ"},
            {"else", "অন্য"},
            {"print", "মুদ্রণ"},
            {"float", "ভাসা"},
            {"input", "ইনপুট"},
            {"str", "str"},
            {"string", "স্ট্রিং"},
            {"def", "ডিফ"},
            {"assert", "জোর_করা"},
            {"exit", "প্রস্থান"},
            {"close", "বন্ধ"},
            {"quit", "ছাড়া"},
            {"return", "ফিরে"},
            {"for", "জন্য"},
            {"in", "মধ্যে"},
            {"range", "পরিসীমা"},
            {"len", "len"},
            {"import", "আমদানি"},
            {"raise", "বাড়াতে"},
            {"module", "মডিউল"},
            {"aclose", "কাছাকাছি"},
            {"True", "সত্য"},
            {"False", "মিথ্যা"},
            {"true", "প্রকৃতয"},
            {"false", "মঅসত্য"},
            {"while", "যখন"},
            {"not", "না"},
            {"and", "এবং"},
            {"del", "ডেল"},
            {"fdel", "fdel"},
            {"or", "বা"},
            {"get", "পেতে"},
            {"fget", "fget"},
            {"break", "বিরতি"},
            {"__init__", "__init__"},
            {"__init_subclass__", "__init_সাবক্লাস__"},
            {"from", "থেকে"},
            {"as", "হিসাবে"},
            {"removesuffix", "প্রত্যয়_অপসারণ"},
            {"suffix", "প্রত্যয়"},
            {"removeprefix", "উপসর্গ_অপসারণ"},
            {"prefix", "উপসর্গ"},
            {"remove", "অপসারণ"},
            {"title", "শিরোনাম"},
            {"upper", "উপরের"},
            {"lower", "নিম্ন"},
            {"append", "সংযোজন"},
            {"clear", "পরিষ্কার"},
            {"pop", "পপ"},
            {"popitem", "popitem"},
            {"shift", "স্থানান্তর"},
            {"lshift", "lshift"},
            {"__lshift__", "__লশিফ্ট__"},
            {"__rlshift__", "__আরএলশিফ্ট__"},
            {"__ilshift__", "__ইলশিফ্ট__"},
            {"rshift", "rshift"},
            {"__rshift__", "__আরশিফ্ট__"},
            {"__rrshift__", "__আরআরশিফট__"},
            {"__irshift__", "__ইরশিফ্ট__"},
            {"unshift", "অপরিবর্তিত"},
            {"insert", "সন্নিবেশ"},
            {"slice", "টুকরা"},
            {"rstrip", "rstrip"},
            {"lstrip", "lstrip"},
            {"strip", "ফালা"},
            {"self", "স্ব"},
            {"this", "এই"},
            {"list", "তালিকা"},
            {"lists", "একাধিক_তালিকা"},
            {"sorted", "সাজানো"},
            {"sort", "সাজান"},
            {"reverse", "বিপরীত"},
            {"__invert__", "__উল্টানো__"},
            {"min", "মিনিট"},
            {"max", "সর্বোচ্চ"},
            {"sum", "যোগফল"},
            {"key", "চাবি"},
            {"keys", "একাধিক_চাবি"},
            {"only_keys", "শুধুমাত্র_কী"},
            {"fromkeys", "চাবি_থেকে"},
            {"fromlines", "থেকে_লাইন"},
            {"__name__", "__নাম__"},
            {"__qualname__", "__কোয়ালিনাম__"},
            {"__module__", "__মডিউল__"},
            {"__defaults__", "__একাধিক_ডিফল্ট__"},
            {"defaults", "একাধিক_ডিফল্ট"},
            {"__code__", "__কোড__"},
            {"code", "কোড"},
            {"__kwdefaults__", "__kwdefaults__"},
            {"type", "টাইপ"},
            {"__type_params__", "__প্রকার_পরামস__"},
            {"__self__", "__স্বয়ং__"},
            {"__func__", "__কাজ__"},
            {"__next__", "__পরবর্তী__"},
            {"__anext__", "__এআই_পরবর্তী__"},
            {"__new__", "__নতুন__"},
            {"__call__", "__কল__"},
            {"__import__", "__আমদানি__"},
            {"__file__", "__ফাইল__"},
            {"__bases__", "__ভিত্তি__"},
            {"__bytes__", "__বাইট__"},
            {"bases", "ঘাঁটি"},
            {"__mro__", "__mro__"},
            {"mro", "mro"},
            {"__subclasses__", "__একাধিক_উপশ্রেণী__"},
            {"__subclass__", "__উপশ্রেণী__"},
            {"subclass", "উপশ্রেণী"},
            {"subclasses", "একাধিক_উপশ্রেণী"},
            {"line", "লাইন"},
            {"cache", "ক্যাশে"},
            {"no_cache", "no_cache"},
            {"clear_cache", "পরিস্কার_ক্যাশে"},
            {"make_file", "make_file"},
            {"make_table", "মেক_টেবিল"},
            {"fobj", "fobj"},
            {"file", "নথি"},
            {"File", "ফাইল"},
            {"__getattr__", "__গেটাত্তর__"},
            {"__get__", "__পাও__"},
            {"__getitem__", "__getitem__"},
            {"__getitems__", "__getitems__"},
            {"__delitem__", "__ডআইটেম_মুছুন__"},
            {"__delitems__", "__একাধিক_আইটেম_মুছুন__"},
            {"__setitem__", "__সেটিটেম__"},
            {"__set__", "__সেট__"},
            {"__set_name_", "__সেট_নাম_"},
            {"__setitems__", "__setitems__"},
            {"__getattribute__", "__গেটাট্রিবিউট__"},
            {"getattribute", "getattribute"},
            {"getattr", "getattr"},
            {"get_close_matches", "বন্ধ_মিলন"},
            {"get_matching_blocks", "প্রাপ্ত_ম্যাচিং_ব্লক"},
            {"__setattr__", "__সেটাত্তর__"},
            {"setattr", "setattr"},
            {"complex", "জটিল"},
            {"__complex__", "__জটিল__"},
            {"conjugate", "কনজুগেট"},
            {"abs", "abs"},
            {"__abs__", "__abs__"},
            {"divmod", "divmod"},
            {"__divmod__", "__divmod__"},
            {"__rdivmod__", "__rdivmod__"},
            {"enumerate", "গণনা_করা"},
            {"enum", "enum"},
            {"IntEnum", "IntEnum"},
            {"_constants", "__একাধিক_ধ্রুবক"},
            {"constants", "একাধিক_ধ্রুবক"},
            {"constant", "ধ্রুবক"},
            {"_NamedIntConstant", "_NamedIntConstant"},
            {"named", "নাম"},
            {"aiter", "আইটার"},
            {"__aiter__", "__এটার__"},
            {"aenter", "প্রবেশ"},
            {"__aenter__", "__এন্টার__"},
            {"iterator", "এক_যে_পুনরাবৃত্তি"},
            {"Iterator", "পুনরাবৃত্তিকারী"},
            {"iterators", "একাধিক_পুনরাবৃত্তিকারী"},
            {"all", "সব"},
            {"any", "যেকোনো"},
            {"bin", "বিন"},
            {"bool", "bool"},
            {"__bool__", "__বুল__"},
            {"breakpoint", "ব্রেকপয়েন্ট"},
            {"bytearray", "bytearray"},
            {"bytes", "একাধিক_বাইট"},
            {"byte", "বাইট"},
            {"callable", "কলযোগ্য"},
            {"pow", "pow"},
            {"__pow__", "__পাউ__"},
            {"__rpow__", "__rpow__"},
            {"__ipow__", "__ipow__"},
            {"chr", "chr"},
            {"char", "চর"},
            {"charset", "অক্ষর_সেট"},
            {"chars", "অক্ষর"},
            {"function", "ফাংশন"},
            {"search_function", "সার্চ_ফাংশন"},
            {"desinscribir", "বর্ণনাকারী"},
            {"EncodedFile", "এনকোড_করা_ফাইল"},
            {"classmethod", "ক্লাস_পদ্ধতি"},
            {"compile", "কম্পাইল"},
            {"delattr", "delattr"},
            {"__delattr__", "__ডেলাত্তর__"},
            {"__delete__", "__মুছে_দিন__"},
            {"__objclass__", "__অবজেক্টক্লাস__"},
            {"dir", "dir"},
            {"directory", "ডিরেক্টরি"},
            {"eval", "eval"},
            {"exec", "exec"},
            {"event", "ঘটনা"},
            {"filter", "ফিল্টার"},
            {"format", "বিন্যাস"},
            {"vformat", "vformat"},
            {"__format__", "__বিন্যাস__"},
            {"hasattr", "hasattr"},
            {"__hasattr__", "__হাসত্তর__"},
            {"hash", "হ্যাশ"},
            {"__hash__", "__হ্যাশ__"},
            {"hashable", "হ্যাশ_করতে_সক্ষম"},
            {"Hashable", "হ্যাশেবল"},
            {"help", "সাহায্য"},
            {"hex", "হেক্স"},
            {"id", "আইডি"},
            {"instance", "ক্লাস_উদাহরণ"},
            {"instances", "একাধিক_শ্রেণীর_উদাহরণ"},
            {"isinstance", "একটি_ক্লাস_উদাহরণ"},
            {"__instancecheck__", "__ইনস্ট্যান্সচেক__"},
            {"__subclasscheck__", "__সাবক্লাসচেক__"},
            {"issubclass", "সাবক্লাস"},
            {"issubset", "একটি_উপসেট"},
            {"subset", "উপসেট"},
            {"iter", "iter"},
            {"locals", "স্থানীয়দের"},
            {"local", "স্থানীয়"},
            {"map", "মানচিত্র"},
            {"next", "পরবর্তী"},
            {"object", "বস্তু"},
            {"obj", "সামগ্রী"},
            {"objects", "অনেক_বস্তু"},
            {"oct", "অক্টোবর"},
            {"open", "খোলা"},
            {"ord", "অনুক্রম"},
            {"unicode", "ইউনিকোড"},
            {"unicodedata", "ইউনিকোড_ডেটা"},
            {"property", "সম্পত্তি"},
            {"__slots__", "__স্লট__"},
            {"__weakref__", "__দুর্বলতা__"},
            {"weakref", "দুর্বল"},
            {"getter", "প্রাপ্ত"},
            {"setter", "সেটার"},
            {"deleter", "ডিলিটার"},
            {"repr", "repr"},
            {"__repr__", "__repr__"},
            {"reversed", "বিপরীত_আদেশ"},
            {"round", "বৃত্তাকার"},
            {"__round__", "__গোলাকার__"},
            {"trunc", "ট্রাঙ্ক"},
            {"__trunc__", "__কাঁটা__"},
            {"__floor__", "__তলা__"},
            {"floor", "মেঝে"},
            {"__ceil__", "__সিল__"},
            {"ceil", "ছাদ"},
            {"start", "শুরু"},
            {"stop", "থামা"},
            {"reset", "রিসেট"},
            {"getstate", "getstate"},
            {"setstate", "সেট_স্টেট"},
            {"step", "পদক্ষেপ"},
            {"static", "স্থির"},
            {"staticmethod", "স্ট্যাটিক_পদ্ধতি"},
            {"method", "পদ্ধতি"},
            {"errors", "একাধিক_ত্রুটি"},
            {"error", "ত্রুটি"},
            {"error_handler", "ত্রুটি_হ্যান্ডলার"},
            {"idna", "idna"},
            {"encoding", "এনকোডিং"},
            {"encodings", "একাধিক_এনকোডিং"},
            {"data_encoding", "ডেটা_এনকোডিং"},
            {"file_encoding", "ফাইল_এনকোডিং"},
            {"encode", "এনকোড"},
            {"encoder", "এনকোডার"},
            {"incrementalencoder", "ইনক্রিমেন্টালেনকোডার"},
            {"IncrementalEncoder", "ইনক্রিমেন্টাল_এনকোডার"},
            {"getencoder", "গেটেনকোডার"},
            {"getincrementalencoder", "ইনক্রিমেন্ট_লেনকোডার"},
            {"decoding", "ডিকোডিং"},
            {"decode", "ডিকোড"},
            {"decoder", "ডিকোডার"},
            {"incrementaldecoder", "একটি_বর্ধিত_ডিকোডার"},
            {"IncrementalDecoder", "ইনক্রিমেন্টাল_ডিকোডার"},
            {"getdecoder", "গেটডিকোডার"},
            {"getincrementaldecoder", "একটি_বর্ধিত_ডিকোডার_পান"},
            {"iterable", "উপর_পুনরাবৃত্তি_করতে_সক্ষম"},
            {"Iterable", "পুনরাবৃত্তিযোগ্য"},
            {"async_iterable", "async_iterable"},
            {"AsyncIterable", "AsyncIterable"},
            {"iterables", "একাধিক_পুনরাবৃত্তিযোগ্য"},
            {"async_iterables", "async_iterables"},
            {"async_iterator", "async_iterator"},
            {"AsyncIterator", "AsyncIterator"},
            {"async_iterators", "async_iterators"},
            {"async_generator", "async_generator"},
            {"async_generators", "async_generators"},
            {"AsyncGenerator", "অ্যাসিঙ্ক_জেনারেটর"},
            {"object_or_type", "অবজেক্ট_বা_টাইপ"},
            {"super", "সুপার"},
            {"tuple", "টিপল"},
            {"kwds", "kwds"},
            {"kwd", "kwd"},
            {"kws", "kws"},
            {"kw", "kw"},
            {"kwarg", "কোয়ার্গ"},
            {"kwargs", "kwargs"},
            {"arg", "arg"},
            {"args", "args"},
            {"__args__", "__আর্গস__"},
            {"vars", "vars"},
            {"strict", "কঠোর"},
            {"zip", "জিপ"},
            {"fromlist", "তালিকা_থেকে"},
            {"level", "স্তর"},
            {"source", "উৎস"},
            {"filename", "ফাইলের_নাম"},
            {"mode", "মোড"},
            {"abiflags", "abiflags"},
            {"addaudithook", "addaudithook"},
            {"hook", "হুক"},
            {"argv", "argv"},
            {"audit", "নিরীক্ষা"},
            {"base_exec_prefix", "base_exec_prefix"},
            {"base_prefix", "base_prefix"},
            {"builtin_module_names", "বিল্টইন_মডিউল_নাম"},
            {"call_tracing", "কল_ট্রেসিং"},
            {"_clear_type_cache", "_ক্লিয়ার_টাইপ_ক্যাশে"},
            {"_current_frames", "_বর্তমান_ফ্রেম"},
            {"_current_exceptions", "_বর্তমান_ব্যতিক্রম"},
            {"breakpointhook", "ব্রেকপয়েন্টহুক"},
            {"flags", "একাধিক_পতাকা"},
            {"flag", "পতাকা"},
            {"IntFlag", "IntFlag"},
            {"dont_inherit", "উত্তরাধিকারী_নয়"},
            {"inherit", "উত্তরাধিকারী"},
            {"optimize", "অপ্টিমাইজ"},
            {"textwrap", "textwrap"},
            {"wrap", "মোড়ানো"},
            {"text", "পাঠ্য"},
            {"number", "সংখ্যা"},
            {"word", "শব্দ"},
            {"possibilities", "সম্ভাবনা"},
            {"cutoff", "কাটঅফ"},
            {"ndiff", "ndiff"},
            {"imag", "ইমেজ"},
            {"complexvalue", "জটিল_মান"},
            {"floatvalue", "floatvalue"},
            {"sign", "চিহ্ন"},
            {"absfloatvalue", "absfloatvalue"},
            {"__float__", "__ভাসা__"},
            {"__int__", "__int__"},
            {"__index__", "__সূচক__"},
            {"index", "সূচক"},
            {"lastindex", "শেষ_সূচক"},
            {"lastgroup", "শেষ_গ্রুপ"},
            {"indices", "একাধিক_সূচক"},
            {"mapping", "ম্যাপিং"},
            {"mappingproxy", "ম্যাপিং_প্রক্সি"},
            {"__dir__", "__দির__"},
            {"expression", "অভিব্যক্তি"},
            {"infinity", "অনন্ত"},
            {"nan", "nan"},
            {"digit", "অঙ্ক"},
            {"digits", "একাধিক_সংখ্যা"},
            {"digitpart", "অঙ্ক_অংশ"},
            {"exponent", "উদ্গাতা"},
            {"exp", "exp"},
            {"format_spec", "বিন্যাস_বিশেষ"},
            {"default", "ডিফল্ট"},
            {"setdefault", "সেট_ডিফল্ট"},
            {"prompt", "প্রম্পট"},
            {"base", "ভিত্তি"},
            {"classinfo", "ক্লাস_ইনফো"},
            {"sentinel", "সেন্টিনেল"},
            {"arg1", "arg1"},
            {"arg2", "arg2"},
            {"arg3", "arg3"},
            {"arg4", "arg4"},
            {"arg5", "arg5"},
            {"offset", "অফসেট"},
            {"unpack", "আনপ্যাক"},
            {"unpack_from", "থেকে_আনপ্যাক"},
            {"iter_unpack", "iter_unpack"},
            {"calcsize", "ক্যালসাইজ"},
            {"codec", "কোডেক"},
            {"codecs", "কএকাধিক_কোডেক"},
            {"CodecInfo", "কোডেক_ইনফো"},
            {"write", "লিখুন"},
            {"writelines", "লেখার_লাইন"},
            {"read", "পড়া"},
            {"stream", "প্রবাহ"},
            {"streamreader", "স্ট্রীডার"},
            {"StreamReader", "স্ট্রিমরিডার"},
            {"Reader", "পাঠক"},
            {"Writer", "লেখক"},
            {"StreamRecoder", "StreamRecoder"},
            {"StreamReaderWriter", "StreamReaderWriter"},
            {"getreader", "গেটরিডার"},
            {"streamwriter", "স্ট্রিমরাইটার"},
            {"StreamWriter", "স্ট্রিম_রাইটার"},
            {"getwriter", "getwriter"},
            {"newline", "নতুন_লাইন"},
            {"closefd", "closefd"},
            {"write_through", "লিখুন_এর_মাধ্যমে"},
            {"opener", "ওপেনার"},
            {"modulo", "মডিউলও"},
            {"modulus", "মডুলাস"},
            {"mod", "মডুল"},
            {"inv_base", "inv_base"},
            {"sep", "sep"},
            {"bytes_per_sep", "bytes_per_sep"},
            {"seperate", "পৃথক"},
            {"end", "শেষ"},
            {"ends", "শএকাধিক_প্রান্ত"},
            {"flush", "ফ্লাশ"},
            {"seq", "seq"},
            {"which", "যা"},
            {"sequence", "পরম্পরা"},
            {"Sequence", "সিকোয়েন্স"},
            {"SequenceMatcher", "সিকোয়েন্স_ম্যাচার"},
            {"Differ", "ভিন্ন"},
            {"HtmlDiff", "এইচটিএমএলডিফ"},
            {"wrapcolumn", "মোড়ানো_কলাম"},
            {"linejunk", "লাইনজাঙ্ক"},
            {"isjunk", "জাঙ্ক"},
            {"autojunk", "অটোজাঙ্ক"},
            {"set_seqs", "set_seqs"},
            {"set_seq1", "set_seq1"},
            {"set_seq2", "set_seq2"},
            {"find_longest_match", "দীর্ঘতম_মিল_খুঁজুন"},
            {"alo", "alo"},
            {"ahi", "আহি"},
            {"blo", "blo"},
            {"bhi", "bhi"},
            {"charjunk", "চারজাঙ্ক"},
            {"IS_CHARACTER_JUNK", "IS_CHARACTER_JUNK"},
            {"MutableSequence", "মিউটেবল_সিকোয়েন্স"},
            {"ndigits", "ndigits"},
            {"ndigit", "ndigit"},
            {"restore", "পুনরুদ্ধার"},
            {"bit_length", "বিট_দৈর্ঘ্য"},
            {"bit_count", "বিট_গণনা"},
            {"new_itemsize", "new_itemsize"},
            {"itemsize", "জিনিসপত্র"},
            {"count", "গণনা"},
            {"to_bytes", "to_bytes"},
            {"tobytes", "টোবাইট"},
            {"from_bytes", "থেকে_বাইট"},
            {"length", "দৈর্ঘ্য"},
            {"byte_length", "বাইট_দৈর্ঘ্য"},
            {"byteorder", "বাইট_অর্ডার"},
            {"order", "ক্রম"},
            {"signed", "স্বাক্ষরিত"},
            {"as_integer_ratio", "হিসাবে_পূর্ণসংখ্যা_অনুপাত"},
            {"is_integer", "is_integer"},
            {"fromhex", "হেক্স_থেকে"},
            {"fraction", "ভগ্নাংশ"},
            {"fractions", "একাধিক_ভগ্নাংশ"},
            {"hash_fraction", "হ্যাশ_ভগ্নাংশ"},
            {"hash_float", "হ্যাশ_ফ্লোট"},
            {"hash_complex", "হ্যাশ_কমপ্লেক্স"},
            {"hash_value", "হ্যাশ_মান"},
            {"__iter__", "__ইটার__"},
            {"join", "যোগদান"},
            {"copy", "অনুলিপি"},
            {"copyright", "কপিরাইট"},
            {"credits", "ক্রেডিট"},
            {"license", "লাইসেন্স"},
            {"extend", "প্রসারিত"},
            {"capitalize", "মূলধন_করা"},
            {"casefold", "কেসফোল্ড"},
            {"doblar", "doblar"},
            {"center", "কেন্দ্র"},
            {"sys", "sys"},
            {"_debugmallocstats", "_debugmallocstats"},
            {"dllhandle", "dllহ্যান্ডেল"},
            {"displayhook", "প্রদর্শন_হুক"},
            {"dont_write_bytecode", "dont_write_bytecode"},
            {"_emscripten_info", "_emscripten_info"},
            {"emscripten_version", "emscripten_সংস্করণ"},
            {"runtime", "রানটাইম"},
            {"pthreads", "pthreads"},
            {"shared_memory", "শেয়ার_করা_মেমরি"},
            {"pycache_prefix", "pycache_prefix"},
            {"excepthook", "ব্যতিক্রমহুক"},
            {"__breakpointhook__", "__ব্রেকপয়েন্টহুক__"},
            {"__displayhook__", "__ডিসপ্লেহুক__"},
            {"__excepthook__", "__বাদে_হুক__"},
            {"__unraisablehook__", "__অরাইজযোগ্য_হুক__"},
            {"exc_info", "exc_info"},
            {"exec_prefix", "exec_prefix"},
            {"executable", "নির্বাহযোগ্য"},
            {"inspect", "পরিদর্শন"},
            {"interactive", "ইন্টারেক্টিভ"},
            {"isolated", "বিচ্ছিন্ন"},
            {"no_user_site", "no_user_site"},
            {"no_site", "no_site"},
            {"ignore_environment", "উপেক্ষা_পরিবেশ"},
            {"bytes_warning", "বাইট_সতর্কতা"},
            {"quiet", "শান্ত"},
            {"hash_randomization", "হ্যাশ_এলোমেলোকরণ"},
            {"dev_mode", "dev_mode"},
            {"utf8_mode", "utf8_মোড"},
            {"safe_path", "নিরাপদ_পথ"},
            {"warn_default_encoding", "সতর্ক_ডিফল্ট_এনকোডিং"},
            {"float_info", "float_info"},
            {"epsilon", "epsilon"},
            {"dig", "খনন"},
            {"mant_dig", "mant_dig"},
            {"max_exp", "max_exp"},
            {"max_10_exp", "max_10_exp"},
            {"min_exp", "min_exp"},
            {"min_10_exp", "min_10_exp"},
            {"radix", "radix"},
            {"rounds", "একাধিক_রাউন্ড"},
            {"float_repr_style", "float_repr_style"},
            {"getallocatedblocks", "বরাদ্দকৃত_ব্লক"},
            {"getunicodeinternedsize", "getunicodeinternedized"},
            {"getandroidapilevel", "অ্যান্ড্রয়েড_পাইলেভেল"},
            {"getdefaultencoding", "ডিফল্টনকোডিং_পান"},
            {"getdlopenflags", "getdlopenflags"},
            {"getfilesystemencoding", "getfilesystemencoding"},
            {"getfilesystemencodeerrors", "getfilesystemencodeerrors"},
            {"get_int_max_str_digits", "get_int_max_str_digits"},
            {"getrefcount", "getrefcount"},
            {"getrecursionlimit", "আবর্তন_সীমা"},
            {"getsizeof", "আকার_পায়"},
            {"getswitchinterval", "getswitchinterval"},
            {"_getframe", "_গেটফ্রেম"},
            {"depth", "গভীরতা"},
            {"_getframemodulename", "_getframe_মডিউল_নাম"},
            {"getprofile", "প্রোফাইল_পেতে"},
            {"gettrace", "গেটট্রেস"},
            {"getwindowsversion", "উইন্ডোজ_সংস্করণ"},
            {"get_asyncgen_hooks", "get_asyncgen_hooks"},
            {"get_coroutine_origin_tracking_depth", "get_coroutine_origin_tracking_depth"},
            {"hash_info", "হ্যাশ_তথ্য"},
            {"inf", "inf"},
            {"algorithm", "অ্যালগরিদম"},
            {"hash_bits", "হ্যাশ_বিট"},
            {"seed_bits", "বীজ_বিট"},
            {"hexversion", "hexversion"},
            {"implementation", "বাস্তবায়ন"},
            {"int_info", "int_info"},
            {"bits_per_digit", "বিট_প্রতি_অঙ্ক"},
            {"sizeof_digit", "sizeof_digit"},
            {"default_max_str_digits", "default_max_str_digits"},
            {"str_digits_check_threshold", "str_digits_check_threshold"},
            {"__interactivehook__", "__ইন্টারেক্টিভ_হুক__"},
            {"intern", "ইন্টার্ন"},
            {"_is_gil_enabled", "_is_gil_enabled"},
            {"is_finalizing", "is_finalizing"},
            {"last_exc", "last_exc"},
            {"_is_interned", "_is_interned"},
            {"last_type", "শেষ_টাইপ"},
            {"last_value", "শেষ_মান"},
            {"last_traceback", "শেষ_ট্রেসব্যাক"},
            {"maxsize", "সর্বাধিক_আকার"},
            {"maxunicode", "ম্যাক্সউনিকোড"},
            {"meta_path", "meta_path"},
            {"modules", "অনেক_মডিউল"},
            {"orig_argv", "orig_argv"},
            {"path_hooks", "path_hooks"},
            {"path_importer_cache", "path_importer_cache"},
            {"platform", "প্ল্যাটফর্ম"},
            {"platlibdir", "platlibdir"},
            {"ps1", "ps1"},
            {"ps2", "ps2"},
            {"setdlopenflags", "setdlopenflags"},
            {"set_int_max_str_digits", "set_int_max_str_digits"},
            {"setprofile", "সেট_প্রোফাইল"},
            {"profilefunc", "প্রোফাইলফাঙ্ক"},
            {"maxdigits", "সর্বাধিক_সংখ্যা"},
            {"setrecursionlimit", "সেট_আবর্তন_সীমা"},
            {"limit", "সীমা"},
            {"setswitchinterval", "setswitchinterval"},
            {"interval", "ব্যবধান"},
            {"settrace", "সেটট্রেস"},
            {"tracefunc", "tracefunc"},
            {"set_asyncgen_hooks", "সেট_অ্যাসিঙ্কজেন_হুক"},
            {"firstiter", "প্রথমবার"},
            {"finalizer", "চূড়ান্তকারী"},
            {"set_coroutine_origin_tracking_depth", "set_coroutine_origin_tracking_depth"},
            {"activate_stack_trampoline", "activate_stack_trampoline"},
            {"backend", "ব্যাকএন্ড"},
            {"deactivate_stack_trampoline", "নিষ্ক্রিয়_স্ট্যাক_ট্রামপোলিন"},
            {"is_stack_trampoline_active", "is_stack_trampoline_active"},
            {"_enablelegacywindowsfsencoding", "_enablelegacywindowsfsencoding"},
            {"stdout", "stdout"},
            {"stdin", "stdin"},
            {"stderr", "stderr"},
            {"__stdin__", "__stdin__"},
            {"__stderr__", "__stderr__"},
            {"__stdout__", "__stdout__"},
            {"stdlib_module_names", "stdlib_module_names"},
            {"thread_info", "থ্রেড_তথ্য"},
            {"lock", "তালা"},
            {"version", "সংস্করণ"},
            {"tracebacklimit", "ট্রেসব্যাকলিমিট"},
            {"unraisablehook", "উত্থাপনযোগ্য_হুক"},
            {"unraisable", "উত্থাপনযোগ্য"},
            {"api_version", "api_version"},
            {"version_info", "সংস্করণ_তথ্য"},
            {"warnoptions", "সতর্কতা"},
            {"winver", "winver"},
            {"monitoring", "পর্যবেক্ষণ"},
            {"_xoptions", "_xবিকল্প"},
            {"asctime", "asctime"},
            {"pthread_getcpuclockid", "pthread_getcpuclockid"},
            {"thread_id", "thread_id"},
            {"clock_getres", "clock_getres"},
            {"clk_id", "clk_id"},
            {"clock_gettime", "clock_gettime"},
            {"clock_gettime_ns", "clock_gettime_ns"},
            {"clock_settime", "clock_settime"},
            {"clock_settime_ns", "clock_settime_ns"},
            {"secs", "সেকেন্ড"},
            {"get_clock_info", "get_clock_info"},
            {"gmtime", "gmtime"},
            {"localtime", "স্থানীয়_সময়"},
            {"mktime", "mktime"},
            {"monotonic", "একঘেয়ে"},
            {"monotonic_ns", "monotonic_ns"},
            {"perf_counter", "পারফ_কাউন্টার"},
            {"perf_counter_ns", "perf_counter_ns"},
            {"process_time", "প্রক্রিয়া_সময়"},
            {"process_time_ns", "প্রক্রিয়া_সময়_এনএস"},
            {"sleep", "ঘুম"},
            {"strftime", "strftime"},
            {"strptime", "strptime"},
            {"struct_time", "struct_time"},
            {"tm_year", "tm_বছর"},
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
            {"time_ns", "সময়_এনএস"},
            {"thread_time", "থ্রেড_টাইম"},
            {"thread_time_ns", "থ্রেড_টাইম_এনএস"},
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
            {"daylight", "দিনের_আলো"},
            {"random", "এলোমেলো"},
            {"seed", "বীজ"},
            {"randbytes", "র্যান্ডবাইট"},
            {"randrange", "randrange"},
            {"randint", "রেন্ডিন্ট"},
            {"getrandbits", "র্যান্ডম_বিট_পেতে"},
            {"choice", "পছন্দ"},
            {"choices", "অনেক_পছন্দ"},
            {"population", "জনসংখ্যা"},
            {"weights", "ওজন"},
            {"cum_weights", "সহ_ওজন"},
            {"shuffle", "এলোমেলো_করতে"},
            {"sample", "নমুনা"},
            {"counts", "একাধিক_গণনা"},
            {"binomialvariate", "দ্বিপদ_বৈচিত্র"},
            {"uniform", "ইউনিফর্ম"},
            {"triangular", "ত্রিভুজাকার"},
            {"low", "কম"},
            {"high", "উচ্চ"},
            {"betavariate", "betavariate"},
            {"alpha", "আলফা"},
            {"beta", "বিটা"},
            {"expovariate", "expovariate"},
            {"lambd", "ল্যাম্বডা"},
            {"gammavariate", "গামাভেরিয়েট"},
            {"gauss", "গাউস"},
            {"sigma", "সিগমা"},
            {"mu", "mu"},
            {"lognormvariate", "lognormvariate"},
            {"normalvariate", "স্বাভাবিক_পরিবর্তনশীল"},
            {"vonmisesvariate", "vonmisesvariate"},
            {"kappa", "কাপ্পা"},
            {"paretovariate", "paretovariate"},
            {"weibullvariate", "weibullvariate"},
            {"Random", "যদৃচ্ছভাবে"},
            {"SystemRandom", "সিস্টেম_র্যান্ডম"},
            {"ArithmeticError", "পাটিগণিত_ত্রুটি"},
            {"AssertionError", "দাবীর_ত্রুটি"},
            {"AttributeError", "বৈশিষ্ট্য_ত্রুটি"},
            {"Exception", "ব্যতিক্রম"},
            {"EOFError", "EOFError"},
            {"FloatingPointError", "FloatingPointError"},
            {"GeneratorExit", "জেনারেটর_প্রস্থান"},
            {"IllegalMonthError", "অবৈধ_মাসের_ত্রুটি"},
            {"IllegalWeekdayError", "অবৈধ_সপ্তাহের_দিন_ত্রুটি৷"},
            {"ImportError", "আমদানি_ত্রুটি"},
            {"IndentationError", "ইন্ডেন্টেশন_ত্রুটি"},
            {"IndexError", "সূচক_ত্রুটি"},
            {"InvalidTZPathWarning", "অবৈধTZPathWarning"},
            {"KeyError", "কী_ত্রুটি"},
            {"KeyboardInterrupt", "কীবোর্ড_ইন্টারাপ্ট"},
            {"LookupError", "লুকআপ_ত্রুটি"},
            {"MemoryError", "মেমরি_ত্রুটি"},
            {"NameError", "নামের_ত্রুটি"},
            {"NotImplementedError", "প্রয়োগ_করা_হয়নি_ত্রুটি৷"},
            {"OSError", "ওএসইরর"},
            {"OverflowError", "ওভারফ্লো_ত্রুটি"},
            {"ReferenceError", "রেফারেন্স_ত্রুটি"},
            {"RuntimeError", "রানটাইম_ত্রুটি"},
            {"StopIteration", "স্টপ_ইটারেশন"},
            {"StopAsyncIteration", "StopAsyncIteration"},
            {"SyntaxError", "সিনট্যাক্স_ত্রুটি"},
            {"TabError", "TabError"},
            {"SystemError", "সিস্টেম_ত্রুটি"},
            {"SystemExit", "সিস্টেম_এক্সিট"},
            {"TypeError", "TypeError"},
            {"UnboundLocalError", "UnboundLocalError"},
            {"UnicodeError", "ইউনিকোড_ত্রুটি"},
            {"UnicodeEncodeError", "ইউনিকোড_এনকোড_ত্রুটি"},
            {"UnicodeDecodeError", "ইউনিকোডডিকোড_ত্রুটি"},
            {"UnicodeTranslateError", "ইউনিকোড_ট্রান্সলেট_ত্রুটি"},
            {"ValueError", "মান_ত্রুটি"},
            {"ZeroDivisionError", "জিরোডিভিশন_ত্রুটি"},
            {"ZoneInfoNotFoundError", "ZoneInfoNotFoundError"},
        };
    }
}
