CREATE TABLE publishers (
    publisher_id NUMBER PRIMARY KEY,
    publisher_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    p_password VARCHAR(255) NOT NULL,
    registration_date DATE
);

CREATE TABLE magazines (
    magazine_id NUMBER PRIMARY KEY,
    publisher_id NUMBER REFERENCES publishers(publisher_id),
    magazine_name VARCHAR(255) NOT NULL,
    publication_date DATE,
    views NUMBER,
    m_category VARCHAR(255)
);

CREATE TABLE subscribers (
    subscriber_id NUMBER PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    s_password VARCHAR(255) NOT NULL,
    registration_date DATE
);

CREATE TABLE subscriptions (
    subscription_id NUMBER PRIMARY KEY,
    subscriber_id NUMBER REFERENCES subscribers(subscriber_id),
    start_date DATE,
    end_date DATE
);

CREATE TABLE followers (
    subscriber_id NUMBER REFERENCES subscribers(subscriber_id),
    publisher_id NUMBER REFERENCES publishers(publisher_id),
    follow_date DATE,
    PRIMARY KEY(subscriber_id, publisher_id)
);

COMMIT;
