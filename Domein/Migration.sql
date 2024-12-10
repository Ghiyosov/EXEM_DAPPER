create database schooll_db;


create table school
(
    school_id serial primary key,
    title varchar(50),
    level_count int,
    is_active bool,
    created_at date,
    updated_at date
);

create type gender as enum('male','female');


create table student
(
    student_id serial primary key,
    student_code varchar(12),
    student_full_name varchar(50),
    gender gender,
    dob date,
    email varchar(75),
    phone varchar(15),
    school_id int references school(school_id),
    stage int,
    section char(2),
    is_active bool,
    join_date date,
    created_at date,
    udated_at date
);


create table parent
(
    parent_id serial primary key,
    parent_code varchar(12),
    parent_full_name varchar(50),
    email varchar(100),
    phone varchar(20),
    created_at date,
    updated_at date
);

create table student_parent
(
    student_parent_id serial primary key,
    student_id int references student(student_id),
    parent_id int references parent(parent_id),
    relationship int
);

create table subject
(
    subject_id serial primary key,
    title varchar(100),
    school_id int references school(school_id),
    stage int,
    term int,
    carry_mark int,
    created_at date,
    updated_at date
);

create table classroom
(
    classroom_id serial primary key,
    capacity int,
    room_typ int,
    description varchar(100),
    created_at date,
    updated_at date

);

create table teacher
(
    teacher_id serial primary key,
    teacher_code varchar(12),
    teacher_full_name varchar(75),
    gender gender,
    dob date,
    email varchar(75),
    phone varchar(15),
    is_active bool,
    join_date date,
    working_days int,
    created_at date,
    updated_at date
);

create table class
(
    class_id serial primary key,
    class_name varchar(50),
    subject_id int references subject(subject_id),
    teacher_id int references teacher(teacher_id),
    classroom_id int references classroom(classroom_id),
    section varchar(20),
    created_at date,
    updated_at date
);

create table class_student
(
    class_student_id serial primary key,
    class_id int references class(class_id),
    student_id int references student(student_id)
);




