// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES PxPackValidationPtr Newer_PxPackValidationPtr(){
    return new std::remove_pointer<PxPackValidationPtr>::type();
}
ES void Freer_PxPackValidationPtr(PxPackValidationPtr ptr){
    delete ptr;
}

ES char PxPackValidationPtr_GET__(PxPackValidationPtr cls) {return (char)cls->_;}
ES void PxPackValidationPtr_SET__(PxPackValidationPtr cls, char value) {cls->_ = value;}

ES long long PxPackValidationPtr_GET_a(PxPackValidationPtr cls) {return (long long)cls->a;}
ES void PxPackValidationPtr_SET_a(PxPackValidationPtr cls, long long value) {cls->a = value;}

